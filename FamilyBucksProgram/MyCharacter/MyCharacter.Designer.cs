namespace FamilyBucksProgram {
    partial class MyCharacter {
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
            this.closeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.jumpCtrl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gravityCtrl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lurchCtrl = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.frictionCtrl = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jumpCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lurchCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frictionCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(497, 367);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 56);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // jumpCtrl
            // 
            this.jumpCtrl.Location = new System.Drawing.Point(50, 338);
            this.jumpCtrl.Name = "jumpCtrl";
            this.jumpCtrl.Size = new System.Drawing.Size(66, 20);
            this.jumpCtrl.TabIndex = 1;
            this.jumpCtrl.Visible = false;
            this.jumpCtrl.ValueChanged += new System.EventHandler(this.jumpCtrl_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jump";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gravity";
            this.label2.Visible = false;
            // 
            // gravityCtrl
            // 
            this.gravityCtrl.Location = new System.Drawing.Point(50, 360);
            this.gravityCtrl.Name = "gravityCtrl";
            this.gravityCtrl.Size = new System.Drawing.Size(66, 20);
            this.gravityCtrl.TabIndex = 3;
            this.gravityCtrl.Visible = false;
            this.gravityCtrl.ValueChanged += new System.EventHandler(this.gravityCtrl_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lurch";
            this.label3.Visible = false;
            // 
            // lurchCtrl
            // 
            this.lurchCtrl.Location = new System.Drawing.Point(50, 383);
            this.lurchCtrl.Name = "lurchCtrl";
            this.lurchCtrl.Size = new System.Drawing.Size(66, 20);
            this.lurchCtrl.TabIndex = 5;
            this.lurchCtrl.Visible = false;
            this.lurchCtrl.ValueChanged += new System.EventHandler(this.lurchCtrl_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Friction";
            this.label4.Visible = false;
            // 
            // frictionCtrl
            // 
            this.frictionCtrl.Location = new System.Drawing.Point(50, 407);
            this.frictionCtrl.Name = "frictionCtrl";
            this.frictionCtrl.Size = new System.Drawing.Size(66, 20);
            this.frictionCtrl.TabIndex = 7;
            this.frictionCtrl.Visible = false;
            this.frictionCtrl.ValueChanged += new System.EventHandler(this.frictionCtrl_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "E - Jump";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "A - Left";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "F - Right";
            // 
            // MyCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FamilyBucksProgram.Properties.Resources.fields;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(602, 435);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frictionCtrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lurchCtrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gravityCtrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jumpCtrl);
            this.Controls.Add(this.closeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyCharacter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Character";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyCharacter_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyCharacter_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyCharacter_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.jumpCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lurchCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frictionCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown jumpCtrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown gravityCtrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lurchCtrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown frictionCtrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}