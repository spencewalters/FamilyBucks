namespace FamilyBucksProgram {
    partial class Administrate {
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
            this.usersListview = new System.Windows.Forms.ListView();
            this.usersLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersListview
            // 
            this.usersListview.Location = new System.Drawing.Point(12, 25);
            this.usersListview.Name = "usersListview";
            this.usersListview.Size = new System.Drawing.Size(341, 161);
            this.usersListview.TabIndex = 0;
            this.usersListview.UseCompatibleStateImageBehavior = false;
            this.usersListview.View = System.Windows.Forms.View.Tile;
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(9, 9);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(34, 13);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "Users";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 192);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 59);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(91, 192);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(73, 59);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(280, 192);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 59);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(280, 283);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(73, 59);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Administrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 354);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.usersListview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usersListview;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
    }
}