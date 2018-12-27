namespace Game_Caro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbCircular = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbRuleGame = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPvsC = new System.Windows.Forms.Button();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.btnPvsP = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pcbCircular);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Caro.Properties.Resources.logo_uit;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pcbCircular
            // 
            this.pcbCircular.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pcbCircular.AnimationSpeed = 0;
            this.pcbCircular.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pcbCircular, "pcbCircular");
            this.pcbCircular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcbCircular.InnerColor = System.Drawing.Color.Yellow;
            this.pcbCircular.InnerMargin = 2;
            this.pcbCircular.InnerWidth = -1;
            this.pcbCircular.MarqueeAnimationSpeed = 2000;
            this.pcbCircular.Maximum = 1000;
            this.pcbCircular.Name = "pcbCircular";
            this.pcbCircular.OuterColor = System.Drawing.Color.DarkGreen;
            this.pcbCircular.OuterMargin = -25;
            this.pcbCircular.OuterWidth = 26;
            this.pcbCircular.ProgressColor = System.Drawing.Color.Lime;
            this.pcbCircular.ProgressWidth = 25;
            this.pcbCircular.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pcbCircular.StartAngle = 270;
            this.pcbCircular.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pcbCircular.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pcbCircular.SubscriptText = "";
            this.pcbCircular.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pcbCircular.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pcbCircular.SuperscriptText = "    ";
            this.pcbCircular.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pcbCircular.Click += new System.EventHandler(this.pcbCircular_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.grbRuleGame);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnNewGame);
            this.panel2.Controls.Add(this.btnPvsC);
            this.panel2.Controls.Add(this.pctbMark);
            this.panel2.Controls.Add(this.btnPvsP);
            this.panel2.Controls.Add(this.txbIP);
            this.panel2.Controls.Add(this.txbPlayerName);
            this.panel2.Name = "panel2";
            // 
            // grbRuleGame
            // 
            resources.ApplyResources(this.grbRuleGame, "grbRuleGame");
            this.grbRuleGame.Name = "grbRuleGame";
            this.grbRuleGame.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNewGame, "btnNewGame");
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPvsC
            // 
            resources.ApplyResources(this.btnPvsC, "btnPvsC");
            this.btnPvsC.Name = "btnPvsC";
            this.btnPvsC.UseVisualStyleBackColor = true;
            this.btnPvsC.Click += new System.EventHandler(this.btnPvsC_Click);
            // 
            // pctbMark
            // 
            resources.ApplyResources(this.pctbMark, "pctbMark");
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.TabStop = false;
            // 
            // btnPvsP
            // 
            resources.ApplyResources(this.btnPvsP, "btnPvsP");
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.UseVisualStyleBackColor = true;
            this.btnPvsP.Click += new System.EventHandler(this.btnPvsP_Click);
            // 
            // txbIP
            // 
            resources.ApplyResources(this.txbIP, "txbIP");
            this.txbIP.Name = "txbIP";
            // 
            // txbPlayerName
            // 
            resources.ApplyResources(this.txbPlayerName, "txbPlayerName");
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.pnlChessBoard, "pnlChessBoard");
            this.pnlChessBoard.Name = "pnlChessBoard";
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meunToolStripMenuItem,
            this.editToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // meunToolStripMenuItem
            // 
            this.meunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.meunToolStripMenuItem.Name = "meunToolStripMenuItem";
            resources.ApplyResources(this.meunToolStripMenuItem, "meunToolStripMenuItem");
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            resources.ApplyResources(this.newGameToolStripMenuItem, "newGameToolStripMenuItem");
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPvsP;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPvsC;
        private System.Windows.Forms.ToolStripMenuItem meunToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.GroupBox grbRuleGame;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private CircularProgressBar.CircularProgressBar pcbCircular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

