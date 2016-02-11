namespace BoulderDash
{
    partial class BDController
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
            this.ssInfos = new System.Windows.Forms.StatusStrip();
            this.sslLife = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslTimeLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslGemLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslKeyPressed = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStartLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrGameLoop = new System.Windows.Forms.Timer(this.components);
            this.pnlPositionning = new System.Windows.Forms.Panel();
            this.ssInfos.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssInfos
            // 
            this.ssInfos.Enabled = false;
            this.ssInfos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslLife,
            this.sslTimeLeft,
            this.sslLevel,
            this.sslScore,
            this.sslGemLeft,
            this.sslKeyPressed});
            this.ssInfos.Location = new System.Drawing.Point(0, 400);
            this.ssInfos.Name = "ssInfos";
            this.ssInfos.Size = new System.Drawing.Size(628, 24);
            this.ssInfos.TabIndex = 0;
            this.ssInfos.Text = "statusStrip1";
            // 
            // sslLife
            // 
            this.sslLife.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslLife.Name = "sslLife";
            this.sslLife.Size = new System.Drawing.Size(39, 19);
            this.sslLife.Text = "Life : ";
            // 
            // sslTimeLeft
            // 
            this.sslTimeLeft.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslTimeLeft.Name = "sslTimeLeft";
            this.sslTimeLeft.Size = new System.Drawing.Size(70, 19);
            this.sslTimeLeft.Text = "Time Left : ";
            // 
            // sslLevel
            // 
            this.sslLevel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslLevel.Name = "sslLevel";
            this.sslLevel.Size = new System.Drawing.Size(47, 19);
            this.sslLevel.Text = "Level : ";
            // 
            // sslScore
            // 
            this.sslScore.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslScore.Name = "sslScore";
            this.sslScore.Size = new System.Drawing.Size(49, 19);
            this.sslScore.Text = "Score : ";
            // 
            // sslGemLeft
            // 
            this.sslGemLeft.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslGemLeft.Name = "sslGemLeft";
            this.sslGemLeft.Size = new System.Drawing.Size(65, 19);
            this.sslGemLeft.Text = "Gem left : ";
            // 
            // sslKeyPressed
            // 
            this.sslKeyPressed.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslKeyPressed.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sslKeyPressed.Name = "sslKeyPressed";
            this.sslKeyPressed.Size = new System.Drawing.Size(80, 19);
            this.sslKeyPressed.Text = "Key pressed : ";
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(628, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPlay,
            this.tsmPause,
            this.tsmExit});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // tsmPlay
            // 
            this.tsmPlay.Name = "tsmPlay";
            this.tsmPlay.Size = new System.Drawing.Size(134, 22);
            this.tsmPlay.Text = "Play";
            // 
            // tsmPause
            // 
            this.tsmPause.Name = "tsmPause";
            this.tsmPause.Size = new System.Drawing.Size(134, 22);
            this.tsmPause.Text = "Pause";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmExit.Size = new System.Drawing.Size(134, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStartLevel,
            this.tsmKeys});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // tsmStartLevel
            // 
            this.tsmStartLevel.CheckOnClick = true;
            this.tsmStartLevel.Name = "tsmStartLevel";
            this.tsmStartLevel.Size = new System.Drawing.Size(152, 22);
            this.tsmStartLevel.Text = "Start Level";
            // 
            // tsmKeys
            // 
            this.tsmKeys.Name = "tsmKeys";
            this.tsmKeys.Size = new System.Drawing.Size(152, 22);
            this.tsmKeys.Text = "Keys";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // tmrGameLoop
            // 
            this.tmrGameLoop.Enabled = true;
            this.tmrGameLoop.Interval = 1;
            this.tmrGameLoop.Tick += new System.EventHandler(this.tmrGameLoop_Tick);
            // 
            // pnlPositionning
            // 
            this.pnlPositionning.Location = new System.Drawing.Point(13, 28);
            this.pnlPositionning.Name = "pnlPositionning";
            this.pnlPositionning.Size = new System.Drawing.Size(600, 360);
            this.pnlPositionning.TabIndex = 2;
            this.pnlPositionning.Visible = false;
            // 
            // BDController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 424);
            this.Controls.Add(this.pnlPositionning);
            this.Controls.Add(this.ssInfos);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "BDController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoulderDash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BDController_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BDController_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BDController_KeyUp);
            this.ssInfos.ResumeLayout(false);
            this.ssInfos.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssInfos;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Timer tmrGameLoop;
        private System.Windows.Forms.ToolStripMenuItem tsmPlay;
        private System.Windows.Forms.ToolStripMenuItem tsmPause;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmKeys;
        private System.Windows.Forms.ToolStripStatusLabel sslLife;
        private System.Windows.Forms.ToolStripMenuItem tsmStartLevel;
        private System.Windows.Forms.ToolStripStatusLabel sslTimeLeft;
        private System.Windows.Forms.ToolStripStatusLabel sslLevel;
        private System.Windows.Forms.ToolStripStatusLabel sslScore;
        private System.Windows.Forms.ToolStripStatusLabel sslGemLeft;
        private System.Windows.Forms.Panel pnlPositionning;
        private System.Windows.Forms.ToolStripStatusLabel sslKeyPressed;
    }
}

