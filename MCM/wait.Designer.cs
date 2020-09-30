namespace MCM
{
    partial class wait
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.circularProgressBar1);
            this.groupBox9.Location = new System.Drawing.Point(13, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(186, 139);
            this.groupBox9.TabIndex = 156;
            this.groupBox9.TabStop = false;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(24, 4);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.DarkRed;
            this.circularProgressBar1.OuterMargin = 0;
            this.circularProgressBar1.OuterWidth = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Yellow;
            this.circularProgressBar1.ProgressWidth = 17;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 13;
            this.circularProgressBar1.Text = "Please Wait";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.circularProgressBar1.Value = 67;
            // 
            // wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 148);
            this.Controls.Add(this.groupBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wait";
            this.Text = "wait";
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}