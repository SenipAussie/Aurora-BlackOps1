
namespace Aurora_BlackOps1_Zombies
{
    partial class AuroraBlackOps1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuroraBlackOps1));
            this.AuroraColor = new System.Windows.Forms.Panel();
            this.AuroraTitle = new System.Windows.Forms.Label();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.lstConsole = new System.Windows.Forms.ListBox();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.picGeneral = new System.Windows.Forms.PictureBox();
            this.pnlTeleports = new System.Windows.Forms.Panel();
            this.lblTeleports = new System.Windows.Forms.Label();
            this.picTeleports = new System.Windows.Forms.PictureBox();
            this.lblHotKeys = new System.Windows.Forms.Label();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picHotKeys = new System.Windows.Forms.PictureBox();
            this.AuroraLogo = new System.Windows.Forms.PictureBox();
            this.WaitingForClose = new System.Windows.Forms.Timer(this.components);
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeneral)).BeginInit();
            this.pnlTeleports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeleports)).BeginInit();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHotKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuroraLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AuroraColor
            // 
            this.AuroraColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(50)))), ((int)(((byte)(251)))));
            this.AuroraColor.Location = new System.Drawing.Point(0, 0);
            this.AuroraColor.Name = "AuroraColor";
            this.AuroraColor.Size = new System.Drawing.Size(998, 5);
            this.AuroraColor.TabIndex = 3;
            this.AuroraColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuroraColor_MouseDown);
            this.AuroraColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuroraColor_MouseMove);
            // 
            // AuroraTitle
            // 
            this.AuroraTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AuroraTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuroraTitle.ForeColor = System.Drawing.Color.White;
            this.AuroraTitle.Location = new System.Drawing.Point(12, 208);
            this.AuroraTitle.Name = "AuroraTitle";
            this.AuroraTitle.Size = new System.Drawing.Size(184, 54);
            this.AuroraTitle.TabIndex = 11;
            this.AuroraTitle.Text = "Aurora";
            this.AuroraTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPage
            // 
            this.pnlPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.pnlPage.Location = new System.Drawing.Point(202, 14);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(786, 650);
            this.pnlPage.TabIndex = 18;
            // 
            // lstConsole
            // 
            this.lstConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.lstConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsole.ForeColor = System.Drawing.Color.White;
            this.lstConsole.FormattingEnabled = true;
            this.lstConsole.ItemHeight = 20;
            this.lstConsole.Location = new System.Drawing.Point(12, 401);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.Size = new System.Drawing.Size(184, 262);
            this.lstConsole.TabIndex = 19;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.pnlGeneral.Controls.Add(this.lblGeneral);
            this.pnlGeneral.Controls.Add(this.picGeneral);
            this.pnlGeneral.Location = new System.Drawing.Point(12, 265);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(184, 45);
            this.pnlGeneral.TabIndex = 20;
            this.pnlGeneral.Click += new System.EventHandler(this.pnlGeneral_Click);
            // 
            // lblGeneral
            // 
            this.lblGeneral.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.ForeColor = System.Drawing.Color.White;
            this.lblGeneral.Location = new System.Drawing.Point(46, 0);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(138, 45);
            this.lblGeneral.TabIndex = 7;
            this.lblGeneral.Text = "General";
            this.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGeneral.Click += new System.EventHandler(this.lblGeneral_Click);
            // 
            // picGeneral
            // 
            this.picGeneral.Image = global::Aurora_BlackOps1_Zombies.Properties.Resources.PlayerIcon;
            this.picGeneral.Location = new System.Drawing.Point(5, 5);
            this.picGeneral.Name = "picGeneral";
            this.picGeneral.Size = new System.Drawing.Size(35, 35);
            this.picGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGeneral.TabIndex = 7;
            this.picGeneral.TabStop = false;
            this.picGeneral.Click += new System.EventHandler(this.picGeneral_Click);
            // 
            // pnlTeleports
            // 
            this.pnlTeleports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlTeleports.Controls.Add(this.lblTeleports);
            this.pnlTeleports.Controls.Add(this.picTeleports);
            this.pnlTeleports.Location = new System.Drawing.Point(12, 310);
            this.pnlTeleports.Name = "pnlTeleports";
            this.pnlTeleports.Size = new System.Drawing.Size(184, 45);
            this.pnlTeleports.TabIndex = 21;
            this.pnlTeleports.Click += new System.EventHandler(this.pnlTeleports_Click);
            // 
            // lblTeleports
            // 
            this.lblTeleports.BackColor = System.Drawing.Color.Transparent;
            this.lblTeleports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeleports.ForeColor = System.Drawing.Color.White;
            this.lblTeleports.Location = new System.Drawing.Point(46, 0);
            this.lblTeleports.Name = "lblTeleports";
            this.lblTeleports.Size = new System.Drawing.Size(138, 45);
            this.lblTeleports.TabIndex = 8;
            this.lblTeleports.Text = "Teleports";
            this.lblTeleports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeleports.Click += new System.EventHandler(this.lblTeleports_Click);
            // 
            // picTeleports
            // 
            this.picTeleports.Image = global::Aurora_BlackOps1_Zombies.Properties.Resources.WorldIcon;
            this.picTeleports.Location = new System.Drawing.Point(5, 5);
            this.picTeleports.Name = "picTeleports";
            this.picTeleports.Size = new System.Drawing.Size(35, 35);
            this.picTeleports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTeleports.TabIndex = 9;
            this.picTeleports.TabStop = false;
            this.picTeleports.Click += new System.EventHandler(this.picTeleports_Click);
            // 
            // lblHotKeys
            // 
            this.lblHotKeys.Location = new System.Drawing.Point(0, 0);
            this.lblHotKeys.Name = "lblHotKeys";
            this.lblHotKeys.Size = new System.Drawing.Size(100, 23);
            this.lblHotKeys.TabIndex = 0;
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.pnlClose.Controls.Add(this.lblClose);
            this.pnlClose.Controls.Add(this.picClose);
            this.pnlClose.Location = new System.Drawing.Point(12, 355);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(184, 45);
            this.pnlClose.TabIndex = 23;
            this.pnlClose.Click += new System.EventHandler(this.pnlClose_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(46, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(138, 45);
            this.lblClose.TabIndex = 8;
            this.lblClose.Text = "Close";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::Aurora_BlackOps1_Zombies.Properties.Resources.ExitIcon;
            this.picClose.Location = new System.Drawing.Point(5, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 9;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picHotKeys
            // 
            this.picHotKeys.Location = new System.Drawing.Point(0, 0);
            this.picHotKeys.Name = "picHotKeys";
            this.picHotKeys.Size = new System.Drawing.Size(100, 50);
            this.picHotKeys.TabIndex = 0;
            this.picHotKeys.TabStop = false;
            // 
            // AuroraLogo
            // 
            this.AuroraLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AuroraLogo.Image = global::Aurora_BlackOps1_Zombies.Properties.Resources.Aurora;
            this.AuroraLogo.Location = new System.Drawing.Point(12, 14);
            this.AuroraLogo.Name = "AuroraLogo";
            this.AuroraLogo.Size = new System.Drawing.Size(184, 205);
            this.AuroraLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AuroraLogo.TabIndex = 10;
            this.AuroraLogo.TabStop = false;
            // 
            // WaitingForClose
            // 
            this.WaitingForClose.Interval = 1000;
            this.WaitingForClose.Tick += new System.EventHandler(this.WaitingForClose_Tick);
            // 
            // AuroraBlackOps1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(997, 672);
            this.Controls.Add(this.pnlClose);
            this.Controls.Add(this.pnlTeleports);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.lstConsole);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.AuroraTitle);
            this.Controls.Add(this.AuroraLogo);
            this.Controls.Add(this.AuroraColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuroraBlackOps1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aurora Black Ops 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuroraBlackOps1_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuroraBlackOps1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuroraBlackOps1_MouseMove);
            this.pnlGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGeneral)).EndInit();
            this.pnlTeleports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTeleports)).EndInit();
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHotKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuroraLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuroraColor;
        private System.Windows.Forms.Label AuroraTitle;
        private System.Windows.Forms.PictureBox AuroraLogo;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.ListBox lstConsole;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.PictureBox picGeneral;
        private System.Windows.Forms.Panel pnlTeleports;
        private System.Windows.Forms.Label lblTeleports;
        private System.Windows.Forms.PictureBox picTeleports;
        private System.Windows.Forms.Label lblHotKeys;
        private System.Windows.Forms.PictureBox picHotKeys;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Timer WaitingForClose;
    }
}

