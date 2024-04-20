namespace WFBlackjack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HitBtn = new Button();
            StandBtn = new Button();
            StartBtn = new Button();
            CardsPanel = new Panel();
            PlayerCardPicBox1 = new PictureBox();
            PlayerCardPicBox2 = new PictureBox();
            PlayerCardPicBox3 = new PictureBox();
            PlayerCardPicBox4 = new PictureBox();
            PlayerCardPicBox5 = new PictureBox();
            PlayerCardPicBox6 = new PictureBox();
            CroupCardPicBox6 = new PictureBox();
            CroupCardPicBox5 = new PictureBox();
            CroupCardPicBox4 = new PictureBox();
            CroupCardPicBox3 = new PictureBox();
            CroupCardPicBox2 = new PictureBox();
            CroupCardPicBox1 = new PictureBox();
            PlayerStatusLabel = new Label();
            BustOrWinLabel = new Label();
            CroupierStatusLabel = new Label();
            CardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox1).BeginInit();
            SuspendLayout();
            // 
            // HitBtn
            // 
            HitBtn.Location = new Point(508, 436);
            HitBtn.Name = "HitBtn";
            HitBtn.Size = new Size(94, 29);
            HitBtn.TabIndex = 0;
            HitBtn.Text = "Hit";
            HitBtn.UseVisualStyleBackColor = true;
            HitBtn.Click += HitBtn_Click;
            // 
            // StandBtn
            // 
            StandBtn.AutoSize = true;
            StandBtn.Location = new Point(508, 471);
            StandBtn.Name = "StandBtn";
            StandBtn.Size = new Size(94, 30);
            StandBtn.TabIndex = 1;
            StandBtn.Text = "Stand";
            StandBtn.UseVisualStyleBackColor = true;
            StandBtn.Click += StandBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(397, 507);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(315, 29);
            StartBtn.TabIndex = 2;
            StartBtn.Text = "Start round";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // CardsPanel
            // 
            CardsPanel.BorderStyle = BorderStyle.FixedSingle;
            CardsPanel.Controls.Add(PlayerCardPicBox1);
            CardsPanel.Controls.Add(PlayerCardPicBox2);
            CardsPanel.Controls.Add(PlayerCardPicBox3);
            CardsPanel.Controls.Add(PlayerCardPicBox4);
            CardsPanel.Controls.Add(PlayerCardPicBox5);
            CardsPanel.Controls.Add(PlayerCardPicBox6);
            CardsPanel.Controls.Add(CroupCardPicBox6);
            CardsPanel.Controls.Add(CroupCardPicBox5);
            CardsPanel.Controls.Add(CroupCardPicBox4);
            CardsPanel.Controls.Add(CroupCardPicBox3);
            CardsPanel.Controls.Add(CroupCardPicBox2);
            CardsPanel.Controls.Add(CroupCardPicBox1);
            CardsPanel.Location = new Point(180, 76);
            CardsPanel.Name = "CardsPanel";
            CardsPanel.Size = new Size(731, 354);
            CardsPanel.TabIndex = 3;
            // 
            // PlayerCardPicBox1
            // 
            PlayerCardPicBox1.Location = new Point(3, 184);
            PlayerCardPicBox1.Name = "PlayerCardPicBox1";
            PlayerCardPicBox1.Size = new Size(115, 165);
            PlayerCardPicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCardPicBox1.TabIndex = 11;
            PlayerCardPicBox1.TabStop = false;
            // 
            // PlayerCardPicBox2
            // 
            PlayerCardPicBox2.Location = new Point(124, 184);
            PlayerCardPicBox2.Name = "PlayerCardPicBox2";
            PlayerCardPicBox2.Size = new Size(115, 165);
            PlayerCardPicBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCardPicBox2.TabIndex = 10;
            PlayerCardPicBox2.TabStop = false;
            // 
            // PlayerCardPicBox3
            // 
            PlayerCardPicBox3.Location = new Point(245, 184);
            PlayerCardPicBox3.Name = "PlayerCardPicBox3";
            PlayerCardPicBox3.Size = new Size(115, 165);
            PlayerCardPicBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCardPicBox3.TabIndex = 9;
            PlayerCardPicBox3.TabStop = false;
            // 
            // PlayerCardPicBox4
            // 
            PlayerCardPicBox4.Location = new Point(366, 184);
            PlayerCardPicBox4.Name = "PlayerCardPicBox4";
            PlayerCardPicBox4.Size = new Size(115, 165);
            PlayerCardPicBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCardPicBox4.TabIndex = 8;
            PlayerCardPicBox4.TabStop = false;
            // 
            // PlayerCardPicBox5
            // 
            PlayerCardPicBox5.Location = new Point(487, 184);
            PlayerCardPicBox5.Name = "PlayerCardPicBox5";
            PlayerCardPicBox5.Size = new Size(115, 165);
            PlayerCardPicBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCardPicBox5.TabIndex = 7;
            PlayerCardPicBox5.TabStop = false;
            // 
            // PlayerCardPicBox6
            // 
            PlayerCardPicBox6.Location = new Point(608, 184);
            PlayerCardPicBox6.Name = "PlayerCardPicBox6";
            PlayerCardPicBox6.Size = new Size(115, 165);
            PlayerCardPicBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCardPicBox6.TabIndex = 6;
            PlayerCardPicBox6.TabStop = false;
            // 
            // CroupCardPicBox6
            // 
            CroupCardPicBox6.Location = new Point(608, 3);
            CroupCardPicBox6.Name = "CroupCardPicBox6";
            CroupCardPicBox6.Size = new Size(115, 165);
            CroupCardPicBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            CroupCardPicBox6.TabIndex = 5;
            CroupCardPicBox6.TabStop = false;
            // 
            // CroupCardPicBox5
            // 
            CroupCardPicBox5.Location = new Point(487, 3);
            CroupCardPicBox5.Name = "CroupCardPicBox5";
            CroupCardPicBox5.Size = new Size(115, 165);
            CroupCardPicBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            CroupCardPicBox5.TabIndex = 4;
            CroupCardPicBox5.TabStop = false;
            // 
            // CroupCardPicBox4
            // 
            CroupCardPicBox4.Location = new Point(366, 3);
            CroupCardPicBox4.Name = "CroupCardPicBox4";
            CroupCardPicBox4.Size = new Size(115, 165);
            CroupCardPicBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            CroupCardPicBox4.TabIndex = 3;
            CroupCardPicBox4.TabStop = false;
            // 
            // CroupCardPicBox3
            // 
            CroupCardPicBox3.Location = new Point(245, 3);
            CroupCardPicBox3.Name = "CroupCardPicBox3";
            CroupCardPicBox3.Size = new Size(115, 165);
            CroupCardPicBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            CroupCardPicBox3.TabIndex = 2;
            CroupCardPicBox3.TabStop = false;
            // 
            // CroupCardPicBox2
            // 
            CroupCardPicBox2.Location = new Point(124, 3);
            CroupCardPicBox2.Name = "CroupCardPicBox2";
            CroupCardPicBox2.Size = new Size(115, 165);
            CroupCardPicBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            CroupCardPicBox2.TabIndex = 1;
            CroupCardPicBox2.TabStop = false;
            // 
            // CroupCardPicBox1
            // 
            CroupCardPicBox1.Location = new Point(3, 3);
            CroupCardPicBox1.Name = "CroupCardPicBox1";
            CroupCardPicBox1.Size = new Size(115, 165);
            CroupCardPicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            CroupCardPicBox1.TabIndex = 0;
            CroupCardPicBox1.TabStop = false;
            // 
            // PlayerStatusLabel
            // 
            PlayerStatusLabel.AutoSize = true;
            PlayerStatusLabel.Location = new Point(511, 33);
            PlayerStatusLabel.Name = "PlayerStatusLabel";
            PlayerStatusLabel.Size = new Size(91, 20);
            PlayerStatusLabel.TabIndex = 4;
            PlayerStatusLabel.Text = "Player status";
            PlayerStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BustOrWinLabel
            // 
            BustOrWinLabel.AutoSize = true;
            BustOrWinLabel.Location = new Point(511, 53);
            BustOrWinLabel.Name = "BustOrWinLabel";
            BustOrWinLabel.Size = new Size(82, 20);
            BustOrWinLabel.TabIndex = 5;
            BustOrWinLabel.Text = "Bust or win";
            BustOrWinLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CroupierStatusLabel
            // 
            CroupierStatusLabel.AutoSize = true;
            CroupierStatusLabel.Location = new Point(511, 13);
            CroupierStatusLabel.Name = "CroupierStatusLabel";
            CroupierStatusLabel.Size = new Size(108, 20);
            CroupierStatusLabel.TabIndex = 6;
            CroupierStatusLabel.Text = "Croupier status";
            CroupierStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 561);
            Controls.Add(CroupierStatusLabel);
            Controls.Add(BustOrWinLabel);
            Controls.Add(PlayerStatusLabel);
            Controls.Add(CardsPanel);
            Controls.Add(StartBtn);
            Controls.Add(StandBtn);
            Controls.Add(HitBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            CardsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardPicBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CroupCardPicBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HitBtn;
        private Button StandBtn;
        private Button StartBtn;
        private Panel CardsPanel;
        private Label PlayerStatusLabel;
        private Label BustOrWinLabel;
        private Label CroupierStatusLabel;
        private PictureBox PlayerCardPicBox1;
        private PictureBox PlayerCardPicBox2;
        private PictureBox PlayerCardPicBox3;
        private PictureBox PlayerCardPicBox4;
        private PictureBox PlayerCardPicBox5;
        private PictureBox PlayerCardPicBox6;
        private PictureBox CroupCardPicBox6;
        private PictureBox CroupCardPicBox5;
        private PictureBox CroupCardPicBox4;
        private PictureBox CroupCardPicBox3;
        private PictureBox CroupCardPicBox2;
        private PictureBox CroupCardPicBox1;
    }
}