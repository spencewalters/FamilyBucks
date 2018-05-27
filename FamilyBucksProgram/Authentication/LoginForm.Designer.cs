namespace FamilyBucksProgram
{
    partial class LoginForm
    {
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.enterPinLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.incorrectPinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(329, 269);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 61);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(200, 269);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(123, 61);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(200, 158);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = 'x';
            this.passwordTxt.Size = new System.Drawing.Size(97, 30);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTxt_KeyDown);
            // 
            // enterPinLabel
            // 
            this.enterPinLabel.AutoSize = true;
            this.enterPinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPinLabel.Location = new System.Drawing.Point(82, 165);
            this.enterPinLabel.Name = "enterPinLabel";
            this.enterPinLabel.Size = new System.Drawing.Size(112, 20);
            this.enterPinLabel.TabIndex = 6;
            this.enterPinLabel.Text = "Enter your PIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FamilyBucksProgram.Properties.Resources.Smiling;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // incorrectPinLabel
            // 
            this.incorrectPinLabel.BackColor = System.Drawing.SystemColors.Control;
            this.incorrectPinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectPinLabel.ForeColor = System.Drawing.Color.Brown;
            this.incorrectPinLabel.Location = new System.Drawing.Point(12, 191);
            this.incorrectPinLabel.Name = "incorrectPinLabel";
            this.incorrectPinLabel.Size = new System.Drawing.Size(392, 60);
            this.incorrectPinLabel.TabIndex = 8;
            this.incorrectPinLabel.Text = "That PIN is incorrect.  Try again!";
            this.incorrectPinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectPinLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 342);
            this.Controls.Add(this.incorrectPinLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enterPinLabel);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label enterPinLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label incorrectPinLabel;
    }
}