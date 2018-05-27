namespace FamilyBucksProgram {
    partial class ParentalSignoff {
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
            this.completedLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionLabel = new System.Windows.Forms.Label();
            this.notYetButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // completedLv
            // 
            this.completedLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.completedLv.Location = new System.Drawing.Point(12, 90);
            this.completedLv.Name = "completedLv";
            this.completedLv.Size = new System.Drawing.Size(402, 192);
            this.completedLv.TabIndex = 0;
            this.completedLv.UseCompatibleStateImageBehavior = false;
            this.completedLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chore";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 120;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(12, 34);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(252, 18);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Did $NAME complete these  chores?";
            // 
            // notYetButton
            // 
            this.notYetButton.Location = new System.Drawing.Point(290, 298);
            this.notYetButton.Name = "notYetButton";
            this.notYetButton.Size = new System.Drawing.Size(124, 51);
            this.notYetButton.TabIndex = 2;
            this.notYetButton.Text = "Not Yet!";
            this.notYetButton.UseVisualStyleBackColor = true;
            this.notYetButton.Click += new System.EventHandler(this.notYetButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(160, 298);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(124, 51);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(12, 52);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(142, 18);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total value: $TOTAL";
            // 
            // ParentalSignoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.notYetButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.completedLv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParentalSignoff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parental Signoff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView completedLv;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button notYetButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label totalLabel;
    }
}