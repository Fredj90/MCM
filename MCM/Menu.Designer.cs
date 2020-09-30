namespace MCM
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nettoyageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nettoyageDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSERSBindingSource
            // 
            // 
           
            // nettoyageDataSetBindingSource
            // 
            this.nettoyageDataSetBindingSource.Position = 0;
            // 
            // uSERSTableAdapter
            // 
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 288);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nettoyageDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nettoyageDataSetBindingSource;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
    }
}