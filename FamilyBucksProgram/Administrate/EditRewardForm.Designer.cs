namespace FamilyBucksProgram {
    partial class EditRewardForm {
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
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.isActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.isAdminCheckbox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pinTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(106, 29);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(122, 20);
            this.usernameTextbox.TabIndex = 17;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(25, 32);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 23;
            this.usernameLabel.Text = "Username";
            // 
            // isActiveCheckbox
            // 
            this.isActiveCheckbox.AutoSize = true;
            this.isActiveCheckbox.Location = new System.Drawing.Point(106, 158);
            this.isActiveCheckbox.Name = "isActiveCheckbox";
            this.isActiveCheckbox.Size = new System.Drawing.Size(56, 17);
            this.isActiveCheckbox.TabIndex = 22;
            this.isActiveCheckbox.Text = "Active";
            this.isActiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // isAdminCheckbox
            // 
            this.isAdminCheckbox.AutoSize = true;
            this.isAdminCheckbox.Location = new System.Drawing.Point(106, 135);
            this.isAdminCheckbox.Name = "isAdminCheckbox";
            this.isAdminCheckbox.Size = new System.Drawing.Size(86, 17);
            this.isAdminCheckbox.TabIndex = 21;
            this.isAdminCheckbox.Text = "Administrator";
            this.isAdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(111, 246);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 52);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(192, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 52);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pinTextbox
            // 
            this.pinTextbox.Location = new System.Drawing.Point(106, 81);
            this.pinTextbox.Name = "pinTextbox";
            this.pinTextbox.Size = new System.Drawing.Size(122, 20);
            this.pinTextbox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "PIN";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(106, 55);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(122, 20);
            this.nameTextbox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // EditRewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 310);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.isActiveCheckbox);
            this.Controls.Add(this.isAdminCheckbox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pinTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRewardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Reward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox isActiveCheckbox;
        private System.Windows.Forms.CheckBox isAdminCheckbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox pinTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label1;
    }
}