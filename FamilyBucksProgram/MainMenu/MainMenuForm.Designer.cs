namespace FamilyBucksProgram {
    partial class MainMenuForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.titleLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.mathBtn = new System.Windows.Forms.Button();
            this.typingLbl = new System.Windows.Forms.Button();
            this.nycBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.balanceValueLbl = new System.Windows.Forms.Label();
            this.rewardsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.freeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.myCharacterButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.LimeGreen;
            this.titleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Linen;
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(442, 45);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Family Bucks!!!";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(12, 57);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(121, 56);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // mathBtn
            // 
            this.mathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathBtn.Location = new System.Drawing.Point(12, 307);
            this.mathBtn.Name = "mathBtn";
            this.mathBtn.Size = new System.Drawing.Size(164, 39);
            this.mathBtn.TabIndex = 3;
            this.mathBtn.Tag = "session";
            this.mathBtn.Text = "Play Math Game!";
            this.mathBtn.UseVisualStyleBackColor = true;
            this.mathBtn.Click += new System.EventHandler(this.mathBtn_Click);
            // 
            // typingLbl
            // 
            this.typingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingLbl.Location = new System.Drawing.Point(266, 262);
            this.typingLbl.Name = "typingLbl";
            this.typingLbl.Size = new System.Drawing.Size(164, 39);
            this.typingLbl.TabIndex = 4;
            this.typingLbl.Tag = "session";
            this.typingLbl.Text = "Play Typing Game!!";
            this.typingLbl.UseVisualStyleBackColor = true;
            // 
            // nycBtn
            // 
            this.nycBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nycBtn.Location = new System.Drawing.Point(266, 307);
            this.nycBtn.Name = "nycBtn";
            this.nycBtn.Size = new System.Drawing.Size(164, 39);
            this.nycBtn.TabIndex = 5;
            this.nycBtn.Tag = "session";
            this.nycBtn.Text = "Drive to NYC!!!";
            this.nycBtn.UseVisualStyleBackColor = true;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.White;
            this.welcomeLbl.Location = new System.Drawing.Point(93, 4);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(82, 17);
            this.welcomeLbl.TabIndex = 6;
            this.welcomeLbl.Text = "Hello guest!";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.ForeColor = System.Drawing.Color.White;
            this.balanceLbl.Location = new System.Drawing.Point(92, 26);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(196, 17);
            this.balanceLbl.TabIndex = 7;
            this.balanceLbl.Text = "Your Family Bucks balance is:";
            // 
            // balanceValueLbl
            // 
            this.balanceValueLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.balanceValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceValueLbl.ForeColor = System.Drawing.Color.Linen;
            this.balanceValueLbl.Location = new System.Drawing.Point(92, 55);
            this.balanceValueLbl.Name = "balanceValueLbl";
            this.balanceValueLbl.Size = new System.Drawing.Size(71, 22);
            this.balanceValueLbl.TabIndex = 8;
            this.balanceValueLbl.Text = "0.00";
            this.balanceValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rewardsBtn
            // 
            this.rewardsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardsBtn.Location = new System.Drawing.Point(314, 6);
            this.rewardsBtn.Name = "rewardsBtn";
            this.rewardsBtn.Size = new System.Drawing.Size(89, 57);
            this.rewardsBtn.TabIndex = 9;
            this.rewardsBtn.Text = "Rewards";
            this.rewardsBtn.UseVisualStyleBackColor = true;
            this.rewardsBtn.Click += new System.EventHandler(this.rewardsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.welcomeLbl);
            this.panel1.Controls.Add(this.balanceValueLbl);
            this.panel1.Controls.Add(this.balanceLbl);
            this.panel1.Controls.Add(this.rewardsBtn);
            this.panel1.Location = new System.Drawing.Point(12, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 88);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FamilyBucksProgram.Properties.Resources.FamilyBucksCoin;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(356, 57);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(74, 56);
            this.aboutBtn.TabIndex = 12;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(378, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 26);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // freeBtn
            // 
            this.freeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeBtn.Location = new System.Drawing.Point(12, 217);
            this.freeBtn.Name = "freeBtn";
            this.freeBtn.Size = new System.Drawing.Size(164, 39);
            this.freeBtn.TabIndex = 14;
            this.freeBtn.Tag = "session";
            this.freeBtn.Text = "FREE Family Buck!";
            this.freeBtn.UseVisualStyleBackColor = true;
            this.freeBtn.Click += new System.EventHandler(this.freeBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 39);
            this.button1.TabIndex = 15;
            this.button1.Tag = "session";
            this.button1.Text = "Did a chore?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myCharacterButton
            // 
            this.myCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCharacterButton.Location = new System.Drawing.Point(207, 57);
            this.myCharacterButton.Name = "myCharacterButton";
            this.myCharacterButton.Size = new System.Drawing.Size(143, 56);
            this.myCharacterButton.TabIndex = 16;
            this.myCharacterButton.Tag = "session";
            this.myCharacterButton.Text = "My Character";
            this.myCharacterButton.UseVisualStyleBackColor = true;
            this.myCharacterButton.Click += new System.EventHandler(this.myCharacterButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 39);
            this.button2.TabIndex = 17;
            this.button2.Tag = "admin";
            this.button2.Text = "Administrate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.administrateClick);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.myCharacterButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.freeBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nycBtn);
            this.Controls.Add(this.typingLbl);
            this.Controls.Add(this.mathBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Bucks Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button mathBtn;
        private System.Windows.Forms.Button typingLbl;
        private System.Windows.Forms.Button nycBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label balanceValueLbl;
        private System.Windows.Forms.Button rewardsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button freeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button myCharacterButton;
        private System.Windows.Forms.Button button2;
    }
}

