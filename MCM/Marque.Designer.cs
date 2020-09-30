namespace MCM
{
    partial class Marque
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.savemarque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wording = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::MCM.Properties.Resources.d21a76863ebd089e021b229ba443c4df;
            this.groupBox4.Controls.Add(this.savemarque);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.wording);
            this.groupBox4.Location = new System.Drawing.Point(12, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 132);
            this.groupBox4.TabIndex = 143;
            this.groupBox4.TabStop = false;
            // 
            // savemarque
            // 
            this.savemarque.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savemarque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savemarque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savemarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savemarque.Location = new System.Drawing.Point(26, 76);
            this.savemarque.Margin = new System.Windows.Forms.Padding(2);
            this.savemarque.Name = "savemarque";
            this.savemarque.Size = new System.Drawing.Size(348, 43);
            this.savemarque.TabIndex = 140;
            this.savemarque.Text = "Save";
            this.savemarque.UseVisualStyleBackColor = false;
            this.savemarque.Click += new System.EventHandler(this.savemarque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Wording           :";
            // 
            // wording
            // 
            this.wording.Cursor = System.Windows.Forms.Cursors.Default;
            this.wording.Location = new System.Drawing.Point(142, 31);
            this.wording.Margin = new System.Windows.Forms.Padding(2);
            this.wording.Name = "wording";
            this.wording.Size = new System.Drawing.Size(184, 20);
            this.wording.TabIndex = 69;
            // 
            // Marque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MCM.Properties.Resources.d21a76863ebd089e021b229ba443c4df;
            this.ClientSize = new System.Drawing.Size(413, 211);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Marque";
            this.Text = "Marque";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button savemarque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wording;
    }
}