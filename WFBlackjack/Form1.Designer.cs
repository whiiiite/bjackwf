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
            PlayerStatusLabel = new Label();
            BustOrWinLabel = new Label();
            CroupierStatusLabel = new Label();
            SuspendLayout();
            // 
            // HitBtn
            // 
            HitBtn.Location = new Point(497, 436);
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
            StandBtn.Location = new Point(497, 471);
            StandBtn.Name = "StandBtn";
            StandBtn.Size = new Size(94, 30);
            StandBtn.TabIndex = 1;
            StandBtn.Text = "Stand";
            StandBtn.UseVisualStyleBackColor = true;
            StandBtn.Click += StandBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(386, 507);
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
            CardsPanel.Location = new Point(145, 63);
            CardsPanel.Name = "CardsPanel";
            CardsPanel.Size = new Size(801, 354);
            CardsPanel.TabIndex = 3;
            // 
            // PlayerStatusLabel
            // 
            PlayerStatusLabel.AutoSize = true;
            PlayerStatusLabel.Location = new Point(511, 18);
            PlayerStatusLabel.Name = "PlayerStatusLabel";
            PlayerStatusLabel.Size = new Size(91, 20);
            PlayerStatusLabel.TabIndex = 4;
            PlayerStatusLabel.Text = "Player status";
            // 
            // BustOrWinLabel
            // 
            BustOrWinLabel.AutoSize = true;
            BustOrWinLabel.Location = new Point(511, 40);
            BustOrWinLabel.Name = "BustOrWinLabel";
            BustOrWinLabel.Size = new Size(82, 20);
            BustOrWinLabel.TabIndex = 5;
            BustOrWinLabel.Text = "Bust or win";
            // 
            // CroupierStatusLabel
            // 
            CroupierStatusLabel.AutoSize = true;
            CroupierStatusLabel.Location = new Point(511, -2);
            CroupierStatusLabel.Name = "CroupierStatusLabel";
            CroupierStatusLabel.Size = new Size(108, 20);
            CroupierStatusLabel.TabIndex = 6;
            CroupierStatusLabel.Text = "Croupier status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 548);
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
    }
}