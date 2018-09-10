namespace FamilyBucksProgram {
    partial class AdministrateForm {
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
            this.usersButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.choresButton = new System.Windows.Forms.Button();
            this.rewardsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(12, 12);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(75, 52);
            this.usersButton.TabIndex = 0;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(247, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // choresButton
            // 
            this.choresButton.Location = new System.Drawing.Point(93, 12);
            this.choresButton.Name = "choresButton";
            this.choresButton.Size = new System.Drawing.Size(75, 52);
            this.choresButton.TabIndex = 2;
            this.choresButton.Text = "Chores";
            this.choresButton.UseVisualStyleBackColor = true;
            this.choresButton.Click += new System.EventHandler(this.choresButton_Click);
            // 
            // rewardsButton
            // 
            this.rewardsButton.Location = new System.Drawing.Point(174, 12);
            this.rewardsButton.Name = "rewardsButton";
            this.rewardsButton.Size = new System.Drawing.Size(75, 52);
            this.rewardsButton.TabIndex = 3;
            this.rewardsButton.Text = "Rewards";
            this.rewardsButton.UseVisualStyleBackColor = true;
            this.rewardsButton.Click += new System.EventHandler(this.rewardsButton_Click);
            // 
            // AdministrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 234);
            this.Controls.Add(this.rewardsButton);
            this.Controls.Add(this.choresButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.usersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button choresButton;
        private System.Windows.Forms.Button rewardsButton;
    }
}