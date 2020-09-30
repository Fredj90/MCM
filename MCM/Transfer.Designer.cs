namespace MCM
{
    partial class Transfer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.savemachine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(351, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "......";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::MCM.Properties.Resources.d21a76863ebd089e021b229ba443c4df;
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.savemachine);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 269);
            this.groupBox3.TabIndex = 140;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MCM.Properties.Resources.Sans_titre;
            this.pictureBox3.Location = new System.Drawing.Point(315, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 148;
            this.pictureBox3.TabStop = false;
            // 
            // savemachine
            // 
            this.savemachine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savemachine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savemachine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savemachine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savemachine.Location = new System.Drawing.Point(75, 134);
            this.savemachine.Margin = new System.Windows.Forms.Padding(2);
            this.savemachine.Name = "savemachine";
            this.savemachine.Size = new System.Drawing.Size(344, 33);
            this.savemachine.TabIndex = 142;
            this.savemachine.Text = "Change";
            this.savemachine.UseVisualStyleBackColor = false;
            this.savemachine.Click += new System.EventHandler(this.savemachine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "File         :";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(126, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 69;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 307);
            this.Controls.Add(this.groupBox3);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button savemachine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}