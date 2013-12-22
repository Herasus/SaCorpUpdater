using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Updater
{

    public class Download
    {

        public static void DownloadFile(string strURL, string strDestination)
        {

            frmMain.isOnRun = true;
            frmMain.srcURL = strURL;
            frmMain.srcDestination = strDestination;

            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_ProgressChanged;
            client.DownloadFileCompleted += client_DownloadCompleted;
            client.DownloadFileAsync(new Uri(strURL), strDestination);

            //Opération d'attente du téléchargement
            while (frmMain.isOnRun)
            {
                Application.DoEvents();
            }
        }

        private static void client_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;


            ChangeTexts(totalBytes, bytesIn, Convert.ToInt32(percentage));
        }

        private static void client_DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            ((frmMain)Application.OpenForms["frmMain"]).ProgressBar1.Value = 100;
            frmMain.isOnRun = false;
        }

        private static void ChangeTexts(double length, double position, int percent)
        {
            ((frmMain)Application.OpenForms["frmMain"]).lblprogress.Text = Math.Round((double)((position / 1024) / 1024), 2) + " MB sur " + Math.Round((double)((length / 1024) / 1024), 2) + "MB (" + percent + "%)";
            ((frmMain)Application.OpenForms["frmMain"]).ProgressBar1.Value = percent;
        }
    }
}
