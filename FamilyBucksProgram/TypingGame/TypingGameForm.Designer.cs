namespace FamilyBucksProgram{
    partial class TypingGameForm {
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.launchLabel = new System.Windows.Forms.Label();
            this.F_keyLabel = new System.Windows.Forms.Label();
            this.R_keyLabel = new System.Windows.Forms.Label();
            this.T_keyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // launchLabel
            // 
            this.launchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchLabel.Location = new System.Drawing.Point(35, 316);
            this.launchLabel.Name = "launchLabel";
            this.launchLabel.Size = new System.Drawing.Size(287, 81);
            this.launchLabel.TabIndex = 0;
            this.launchLabel.Text = "Launching:";
            this.launchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_keyLabel
            // 
            this.F_keyLabel.AutoSize = true;
            this.F_keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_keyLabel.Location = new System.Drawing.Point(303, 609);
            this.F_keyLabel.Name = "F_keyLabel";
            this.F_keyLabel.Size = new System.Drawing.Size(19, 20);
            this.F_keyLabel.TabIndex = 1;
            this.F_keyLabel.Text = "F";
            // 
            // R_keyLabel
            // 
            this.R_keyLabel.AutoSize = true;
            this.R_keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_keyLabel.Location = new System.Drawing.Point(293, 575);
            this.R_keyLabel.Name = "R_keyLabel";
            this.R_keyLabel.Size = new System.Drawing.Size(21, 20);
            this.R_keyLabel.TabIndex = 2;
            this.R_keyLabel.Text = "R";
            // 
            // T_keyLabel
            // 
            this.T_keyLabel.AutoSize = true;
            this.T_keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_keyLabel.Location = new System.Drawing.Point(320, 576);
            this.T_keyLabel.Name = "T_keyLabel";
            this.T_keyLabel.Size = new System.Drawing.Size(18, 20);
            this.T_keyLabel.TabIndex = 3;
            this.T_keyLabel.Text = "T";
            // 
            // TypingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FamilyBucksProgram.Properties.Resources.TypingProgram_1;
            this.ClientSize = new System.Drawing.Size(920, 661);
            this.Controls.Add(this.T_keyLabel);
            this.Controls.Add(this.R_keyLabel);
            this.Controls.Add(this.F_keyLabel);
            this.Controls.Add(this.launchLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypingGameForm";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypingGameForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TypingGameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypingGameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label launchLabel;
        private System.Windows.Forms.Label F_keyLabel;
        private System.Windows.Forms.Label R_keyLabel;
        private System.Windows.Forms.Label T_keyLabel;
    }
}