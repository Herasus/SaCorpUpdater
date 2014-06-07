namespace Updater
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdLaunch = new System.Windows.Forms.Button();
            this.lblprogress = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressNbrVersions = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(520, 371);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "A propos";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(295, 361);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(97, 23);
            this.cmdQuit.TabIndex = 12;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmdLaunch
            // 
            this.cmdLaunch.Location = new System.Drawing.Point(192, 361);
            this.cmdLaunch.Name = "cmdLaunch";
            this.cmdLaunch.Size = new System.Drawing.Size(97, 23);
            this.cmdLaunch.TabIndex = 11;
            this.cmdLaunch.Text = "Démarrer";
            this.cmdLaunch.UseVisualStyleBackColor = true;
            this.cmdLaunch.Click += new System.EventHandler(this.cmdLaunch_Click);
            // 
            // lblprogress
            // 
            this.lblprogress.BackColor = System.Drawing.Color.Transparent;
            this.lblprogress.Location = new System.Drawing.Point(12, 336);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(509, 19);
            this.lblprogress.TabIndex = 10;
            this.lblprogress.Text = "Initialisation... Merci de patienter.";
            this.lblprogress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(9, 305);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(563, 20);
            this.ProgressBar1.TabIndex = 9;
            this.ProgressBar1.Value = 100;
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Location = new System.Drawing.Point(10, 44);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(559, 225);
            this.WebBrowser1.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(5, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(572, 39);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "SaCorp Updater v2";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressNbrVersions
            // 
            this.progressNbrVersions.Location = new System.Drawing.Point(9, 280);
            this.progressNbrVersions.Name = "progressNbrVersions";
            this.progressNbrVersions.Size = new System.Drawing.Size(563, 20);
            this.progressNbrVersions.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressNbrVersions.TabIndex = 14;
            this.progressNbrVersions.Value = 100;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.progressNbrVersions);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdLaunch);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaCorp Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button cmdQuit;
        public System.Windows.Forms.Button cmdLaunch;
        public System.Windows.Forms.Label lblprogress;
        public System.Windows.Forms.ProgressBar ProgressBar1;
        public System.Windows.Forms.WebBrowser WebBrowser1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ProgressBar progressNbrVersions;



    }
}

