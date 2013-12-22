using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;

namespace Updater
{
    public class Unzip
    {
        public static void ExtractArchive(string zipFilename, string ExtractDir)
        {
            ZipInputStream MyZipInputStream = default(ZipInputStream);
            FileStream MyFileStream = default(FileStream);
            MyZipInputStream = new ZipInputStream(new FileStream(zipFilename, FileMode.Open, FileAccess.Read));
            ZipEntry MyZipEntry = MyZipInputStream.GetNextEntry();
            Directory.CreateDirectory(ExtractDir);
            while ((MyZipEntry != null))
            {
                if ((MyZipEntry.IsDirectory))
                {
                    Directory.CreateDirectory(ExtractDir + "\\" + MyZipEntry.Name);
                }
                else
                {
                    if (!Directory.Exists(ExtractDir + "\\" + Path.GetDirectoryName(MyZipEntry.Name)))
                    {
                        Directory.CreateDirectory(ExtractDir + "\\" + Path.GetDirectoryName(MyZipEntry.Name));
                    }
                    MyFileStream = new FileStream(ExtractDir + "\\" + MyZipEntry.Name, FileMode.OpenOrCreate, FileAccess.Write);
                    int count = 0;
                    byte[] buffer = new byte[4097];
                    count = MyZipInputStream.Read(buffer, 0, 4096);
                    while (count > 0)
                    {
                        MyFileStream.Write(buffer, 0, count);
                        count = MyZipInputStream.Read(buffer, 0, 4096);
                    }
                    MyFileStream.Close();
                }
                try
                {
                    MyZipEntry = MyZipInputStream.GetNextEntry();
                }
                catch (Exception ex)
                {
                    MyZipEntry = null;
                    System.Windows.Forms.MessageBox.Show("Erreur : " + ex.ToString());
                }
            }
            if ((MyZipInputStream != null))
                MyZipInputStream.Close();
            if ((MyFileStream != null))
                MyFileStream.Close();
        }
    }
}
