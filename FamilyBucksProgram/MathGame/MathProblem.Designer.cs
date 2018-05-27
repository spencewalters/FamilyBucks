namespace FamilyBucksProgram
{
    partial class MathProblem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.wrongPic = new System.Windows.Forms.PictureBox();
            this.correctPic = new System.Windows.Forms.PictureBox();
            this.answerTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.operatorLbl = new System.Windows.Forms.Label();
            this.lowerNumberLbl = new System.Windows.Forms.Label();
            this.topNumberLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.wrongPic);
            this.panel1.Controls.Add(this.correctPic);
            this.panel1.Controls.Add(this.answerTxt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.operatorLbl);
            this.panel1.Controls.Add(this.lowerNumberLbl);
            this.panel1.Controls.Add(this.topNumberLbl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 179);
            this.panel1.TabIndex = 14;
            // 
            // wrongPic
            // 
            this.wrongPic.BackColor = System.Drawing.Color.Black;
            this.wrongPic.Image = global::FamilyBucksProgram.Properties.Resources.thumb_down;
            this.wrongPic.Location = new System.Drawing.Point(5, 7);
            this.wrongPic.Name = "wrongPic";
            this.wrongPic.Size = new System.Drawing.Size(60, 47);
            this.wrongPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrongPic.TabIndex = 6;
            this.wrongPic.TabStop = false;
            // 
            // correctPic
            // 
            this.correctPic.BackColor = System.Drawing.Color.Black;
            this.correctPic.Image = global::FamilyBucksProgram.Properties.Resources.thumb_up;
            this.correctPic.Location = new System.Drawing.Point(5, 6);
            this.correctPic.Name = "correctPic";
            this.correctPic.Size = new System.Drawing.Size(60, 47);
            this.correctPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.correctPic.TabIndex = 5;
            this.correctPic.TabStop = false;
            // 
            // answerTxt
            // 
            this.answerTxt.AcceptsReturn = true;
            this.answerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTxt.Location = new System.Drawing.Point(27, 124);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(127, 41);
            this.answerTxt.TabIndex = 4;
            this.answerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.answerTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerTxt_KeyDown);
            this.answerTxt.Leave += new System.EventHandler(this.answerTxt_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(16, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 10);
            this.panel2.TabIndex = 3;
            // 
            // operatorLbl
            // 
            this.operatorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorLbl.Location = new System.Drawing.Point(3, 54);
            this.operatorLbl.Name = "operatorLbl";
            this.operatorLbl.Size = new System.Drawing.Size(50, 45);
            this.operatorLbl.TabIndex = 2;
            this.operatorLbl.Text = "+";
            this.operatorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lowerNumberLbl
            // 
            this.lowerNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerNumberLbl.Location = new System.Drawing.Point(59, 54);
            this.lowerNumberLbl.Name = "lowerNumberLbl";
            this.lowerNumberLbl.Size = new System.Drawing.Size(96, 45);
            this.lowerNumberLbl.TabIndex = 1;
            this.lowerNumberLbl.Text = "19";
            this.lowerNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // topNumberLbl
            // 
            this.topNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topNumberLbl.Location = new System.Drawing.Point(59, 9);
            this.topNumberLbl.Name = "topNumberLbl";
            this.topNumberLbl.Size = new System.Drawing.Size(96, 45);
            this.topNumberLbl.TabIndex = 0;
            this.topNumberLbl.Text = "19";
            this.topNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MathProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MathProblem";
            this.Size = new System.Drawing.Size(182, 185);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox correctPic;
        private System.Windows.Forms.TextBox answerTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label operatorLbl;
        private System.Windows.Forms.Label lowerNumberLbl;
        private System.Windows.Forms.Label topNumberLbl;
        private System.Windows.Forms.PictureBox wrongPic;
    }
}
