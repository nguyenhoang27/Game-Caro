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
            this.pctbAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctbAvatar);
            this.panel1.Location = new System.Drawing.Point(780, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 259);
            this.panel1.TabIndex = 0;
            // 
            // pctbAvatar
            // 
            this.pctbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbAvatar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pctbAvatar.BackgroundImage = global::Game_Caro.Properties.Resources.logo_uit;
            this.pctbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctbAvatar.Location = new System.Drawing.Point(3, 3);
            this.pctbAvatar.Name = "pctbAvatar";
            this.pctbAvatar.Size = new System.Drawing.Size(256, 256);
            this.pctbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbAvatar.TabIndex = 0;
            this.pctbAvatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pctbMark);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLAN);
            this.panel2.Controls.Add(this.txbIP);
            this.panel2.Controls.Add(this.prcbCoolDown);
            this.panel2.Controls.Add(this.txbPlayerName);
            this.panel2.Location = new System.Drawing.Point(780, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 423);
            this.panel2.TabIndex = 1;
            // 
            // pctbMark
            // 
            this.pctbMark.Location = new System.Drawing.Point(125, 11);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(125, 125);
            this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMark.TabIndex = 6;
            this.pctbMark.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Luật chơi";
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(36, 256);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(75, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(12, 110);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(100, 20);
            this.txbIP.TabIndex = 3;
            this.txbIP.Text = "192.168.0.1";
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(15, 64);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(100, 23);
            this.prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(12, 18);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txbPlayerName.TabIndex = 0;
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(701, 701);
            this.pnlChessBoard.TabIndex = 2;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 725);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctbAvatar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.Timer tmCoolDown;
    }
}

