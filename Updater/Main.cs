using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Updater
{
    class Main
    {
        public static bool isMaj = true;

        public static void programMain()
        {
            string file = Application.StartupPath + "\\Config\\Launcher.ini";
            if (File.Exists(Application.StartupPath + "\\Config\\Launcher.ini") == false)
                DestroyUpdater();
            if (File.Exists(Application.StartupPath + "\\" + "SharpZipLib.dll") == false)
                DestroyUpdater();

            frmMain.exename = ReadIni.GetVar(file, "SERVER", "exename");
            frmMain.UpdateURL = ReadIni.GetVar(file, "SERVER", "updateurl");
            frmMain.appname = ReadIni.GetVar(file, "GENERAL", "gamename");
            frmMain.newsurl = ReadIni.GetVar(file, "GENERAL", "newsurl");

            ((frmMain)Application.OpenForms["frmMain"]).cmdLaunch.Text = ReadIni.GetVar(file, "TEXT", "launch");
            ((frmMain)Application.OpenForms["frmMain"]).cmdQuit.Text = ReadIni.GetVar(file, "TEXT", "quit");

            ((frmMain)Application.OpenForms["frmMain"]).WebBrowser1.Navigate(frmMain.newsurl);

            ((frmMain)Application.OpenForms["frmMain"]).lblTitle.Text = frmMain.appname;
            ((frmMain)Application.OpenForms["frmMain"]).Text = frmMain.appname;

        }

        public static void DestroyUpdater()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\tmpUpdate.ini")) File.Delete(Application.StartupPath + "\tmpUpdate.ini");
            Environment.Exit(0);
        }

        public static void AddProgress(string progress)
        {
            ((frmMain)Application.OpenForms["frmMain"]).lblprogress.Text = progress;
        }

        public static void UpdateProgram()
        {
            int CurVersion = 0;
            int verMaj = 0;
            string Filename = null;
            int Index = 0;

            AddProgress("Connexion au serveur de " + frmMain.appname + " en cours...");
            Download.DownloadFile(frmMain.UpdateURL + "/update.ini", Application.StartupPath + "\\tmpUpdate.ini",0);
            Application.DoEvents();
            AddProgress("Connexion au serveur réussie, en attente d'informations...");
            frmMain.VersionCount = Convert.ToInt32(ReadIni.GetVar(Application.StartupPath + "\\tmpUpdate.ini", "FILES", "versions"));
            if (File.Exists(Application.StartupPath + "\\Config\\version.ini"))
            {
                CurVersion = Convert.ToInt32(ReadIni.GetVar(Application.StartupPath + "\\Config\\version.ini", "UPDATER", "CurVersion"));
            }
            else
            {
                CurVersion = 0;
            }
            Application.DoEvents();
            if (CurVersion < frmMain.VersionCount)
            {
                if (CurVersion < 0)
                    CurVersion = 0;
                verMaj = CurVersion + 1;
                for (Index = verMaj; Index <= frmMain.VersionCount; Index++)
                {

                    ((frmMain)Application.OpenForms["frmMain"]).progressNbrVersions.Maximum = (frmMain.VersionCount - CurVersion) * 2;
                    ((frmMain)Application.OpenForms["frmMain"]).progressNbrVersions.Value = (Index - CurVersion) * 2 - 1;


                    frmMain.IndexVersionDownload = Index;
                    AddProgress("Téléchargement de la version " + Index + " - ");
                    Filename = "version" + Index + ".zip";
                    ((frmMain)Application.OpenForms["frmMain"]).ProgressBar1.Style = ProgressBarStyle.Blocks;
                    Download.DownloadFile(frmMain.UpdateURL + "/" + Filename, Application.StartupPath + "\\" + Filename, Index);
                    ((frmMain)Application.OpenForms["frmMain"]).ProgressBar1.Style = ProgressBarStyle.Marquee;




                    ((frmMain)Application.OpenForms["frmMain"]).progressNbrVersions.Value = (Index - CurVersion) * 2;


                    Application.DoEvents();
                    AddProgress("Extraction de la version " + Index + "...");
                    Application.DoEvents();
                    Unzip.ExtractArchive(Application.StartupPath + "\\" + Filename, Application.StartupPath + "\\");
                    File.Delete(Application.StartupPath + "\\" + Filename);
                    ReadIni.PutVar(Application.StartupPath + "\\Config\\version.ini", "UPDATER", "CurVersion", Convert.ToString(Index));
                    ((frmMain)Application.OpenForms["frmMain"]).ProgressBar1.Style = ProgressBarStyle.Blocks;
                    AddProgress("Version " + Index + " installé.");
                    Application.DoEvents();
                }
                AddProgress("Les mises à jour sont terminées, vous pouvez dorénavant lancer " + frmMain.appname + ".");
            }
            else
            {
                AddProgress("Vous êtes à jour, vous pouvez dorénavant lancer " + frmMain.appname + ".");
            }
            ((frmMain)Application.OpenForms["frmMain"]).cmdLaunch.Enabled = true;
            isMaj = false;

        }
    }
}
