namespace FamilyBucksProgram
{
    partial class MathGameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathGameForm));
            this.button1 = new System.Windows.Forms.Button();
            this.countdownClockLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.correctLbl = new System.Windows.Forms.Label();
            this.earningsLbl = new System.Windows.Forms.Label();
            this.smileFacePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.smileFacePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(967, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countdownClockLbl
            // 
            this.countdownClockLbl.BackColor = System.Drawing.Color.Black;
            this.countdownClockLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countdownClockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownClockLbl.ForeColor = System.Drawing.Color.Gold;
            this.countdownClockLbl.Location = new System.Drawing.Point(15, 11);
            this.countdownClockLbl.Name = "countdownClockLbl";
            this.countdownClockLbl.Size = new System.Drawing.Size(114, 47);
            this.countdownClockLbl.TabIndex = 1;
            this.countdownClockLbl.Text = "00:00";
            this.countdownClockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // correctLbl
            // 
            this.correctLbl.BackColor = System.Drawing.Color.Black;
            this.correctLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.correctLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLbl.ForeColor = System.Drawing.Color.LawnGreen;
            this.correctLbl.Location = new System.Drawing.Point(135, 11);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(114, 48);
            this.correctLbl.TabIndex = 2;
            this.correctLbl.Text = "0";
            this.correctLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // earningsLbl
            // 
            this.earningsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.earningsLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.earningsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsLbl.ForeColor = System.Drawing.Color.Linen;
            this.earningsLbl.Location = new System.Drawing.Point(1017, 62);
            this.earningsLbl.Name = "earningsLbl";
            this.earningsLbl.Size = new System.Drawing.Size(53, 22);
            this.earningsLbl.TabIndex = 12;
            this.earningsLbl.Text = "0.00";
            this.earningsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smileFacePic
            // 
            this.smileFacePic.BackColor = System.Drawing.Color.Transparent;
            this.smileFacePic.Image = global::FamilyBucksProgram.Properties.Resources.Smiling;
            this.smileFacePic.Location = new System.Drawing.Point(210, 62);
            this.smileFacePic.Name = "smileFacePic";
            this.smileFacePic.Size = new System.Drawing.Size(713, 441);
            this.smileFacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smileFacePic.TabIndex = 13;
            this.smileFacePic.TabStop = false;
            this.smileFacePic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FamilyBucksProgram.Properties.Resources.FamilyBucksCoin;
            this.pictureBox1.Location = new System.Drawing.Point(1017, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MathGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1082, 559);
            this.Controls.Add(this.smileFacePic);
            this.Controls.Add(this.earningsLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.countdownClockLbl);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1098, 598);
            this.Name = "MathGameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Math Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MathGameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.smileFacePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label countdownClockLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label earningsLbl;
        private System.Windows.Forms.PictureBox smileFacePic;
    }
}