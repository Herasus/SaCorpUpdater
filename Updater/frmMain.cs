using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Updater
{
    

    public partial class frmMain : Form
    {
        public static string srcDestination;
        public static string srcURL;

        //public static string cf = ControlChars.CrLf;

        public static bool isOnRun = true;

        public static long IndexVersionDownload = 0;
        public static string exename;
        public static string UpdateURL;
        public static string appname;
        public static string newsurl;
        public static int VersionCount;

        private frmAbout frm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string Filename = null;
            System.Drawing.Image img = null;
            Main.programMain();

            Filename = Application.StartupPath + "\\Config\\sacorpupdater.jpg";

            if (System.IO.File.Exists(Filename) == true)
            {
                img = new Bitmap(Filename, true);
                this.BackgroundImage = img;
            }

            cmdLaunch.Enabled = false;
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            if (isOnRun)
            {
                if (MessageBox.Show("Une mise à jour est en cours. Voulez-vous vraiment quitter ?", appname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Main.DestroyUpdater();
                }
            }
            else
            {
                Main.DestroyUpdater();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void cmdLaunch_Click(object sender, EventArgs e)
        {
            Process P = Process.Start(Application.StartupPath + "\\" + exename);
            Main.DestroyUpdater();
        }

        private void tmrstart_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Main.UpdateProgram();
            Application.DoEvents();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            frm = new frmAbout();
            frm.Show();
        }




    }
}
