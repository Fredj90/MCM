namespace MCM
{
    partial class Machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Machine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateTimemachine = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savemachine = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mARQUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRRANettoyageDataSetMarque = new MCM.HRRANettoyageDataSetMarque();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ADD = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mACHINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRRANettoyageDataSetMachine = new MCM.HRRANettoyageDataSetMachine();
            this.mACHINETableAdapter = new MCM.HRRANettoyageDataSetMachineTableAdapters.MACHINETableAdapter();
            this.mARQUETableAdapter = new MCM.HRRANettoyageDataSetMarqueTableAdapters.MARQUETableAdapter();
            this.dataGridViewmachine = new System.Windows.Forms.DataGridView();
            this.Registration_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_Manufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wording = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARQUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRANettoyageDataSetMarque)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRANettoyageDataSetMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmachine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::MCM.Properties.Resources.d21a76863ebd089e021b229ba443c4df;
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.dateTimemachine);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.savemachine);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(211, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 261);
            this.groupBox3.TabIndex = 139;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MCM.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(357, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MCM.Properties.Resources.exit;
            this.pictureBox3.Location = new System.Drawing.Point(358, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 148;
            this.pictureBox3.TabStop = false;
            // 
            // dateTimemachine
            // 
            this.dateTimemachine.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimemachine.CustomFormat = "dd/MM/yyyy";
            this.dateTimemachine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimemachine.Location = new System.Drawing.Point(170, 158);
            this.dateTimemachine.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimemachine.Name = "dateTimemachine";
            this.dateTimemachine.Size = new System.Drawing.Size(184, 20);
            this.dateTimemachine.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 145;
            this.label5.Text = "Date of Manufacture :";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Location = new System.Drawing.Point(168, 118);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 144;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 143;
            this.label2.Text = "Registration num :";
            // 
            // savemachine
            // 
            this.savemachine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savemachine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savemachine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savemachine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savemachine.Location = new System.Drawing.Point(61, 211);
            this.savemachine.Margin = new System.Windows.Forms.Padding(2);
            this.savemachine.Name = "savemachine";
            this.savemachine.Size = new System.Drawing.Size(344, 33);
            this.savemachine.TabIndex = 142;
            this.savemachine.Text = "Save";
            this.savemachine.UseVisualStyleBackColor = false;
            this.savemachine.Click += new System.EventHandler(this.savemachine_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(357, 65);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 31);
            this.button5.TabIndex = 141;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Wording           :";
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox2.DataSource = this.mARQUEBindingSource;
            this.comboBox2.DisplayMember = "LIBELLE";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "LIBELLE";
            // 
            // mARQUEBindingSource
            // 
            this.mARQUEBindingSource.DataMember = "MARQUE";
            this.mARQUEBindingSource.DataSource = this.hRRANettoyageDataSetMarque;
            // 
            // hRRANettoyageDataSetMarque
            // 
            this.hRRANettoyageDataSetMarque.DataSetName = "HRRANettoyageDataSetMarque";
            this.hRRANettoyageDataSetMarque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(169, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 69;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Mark                 :";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.BackgroundImage = global::MCM.Properties.Resources.d21a76863ebd089e021b229ba443c4df;
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.ADD);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Location = new System.Drawing.Point(468, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(401, 51);
            this.groupBox6.TabIndex = 144;
            this.groupBox6.TabStop = false;
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADD.Image = ((System.Drawing.Image)(resources.GetObject("ADD.Image")));
            this.ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADD.Location = new System.Drawing.Point(18, 8);
            this.ADD.Margin = new System.Windows.Forms.Padding(2);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(128, 33);
            this.ADD.TabIndex = 138;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(155, 8);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 33);
            this.button4.TabIndex = 139;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mACHINEBindingSource
            // 
            this.mACHINEBindingSource.DataMember = "MACHINE";
            this.mACHINEBindingSource.DataSource = this.hRRANettoyageDataSetMachine;
            // 
            // hRRANettoyageDataSetMachine
            // 
            this.hRRANettoyageDataSetMachine.DataSetName = "HRRANettoyageDataSetMachine";
            this.hRRANettoyageDataSetMachine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mACHINETableAdapter
            // 
            this.mACHINETableAdapter.ClearBeforeFill = true;
            // 
            // mARQUETableAdapter
            // 
            this.mARQUETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewmachine
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewmachine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewmachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmachine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registration_num,
            this.Date_of_Manufacture,
            this.wording,
            this.marque,
            this.id_machine,
            this.id_marque});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewmachine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewmachine.Location = new System.Drawing.Point(174, 6);
            this.dataGridViewmachine.Name = "dataGridViewmachine";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewmachine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewmachine.Size = new System.Drawing.Size(445, 269);
            this.dataGridViewmachine.TabIndex = 147;
            this.dataGridViewmachine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewmachine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Registration_num
            // 
            this.Registration_num.HeaderText = "Registration num";
            this.Registration_num.Name = "Registration_num";
            // 
            // Date_of_Manufacture
            // 
            this.Date_of_Manufacture.HeaderText = "Date of Manufacture";
            this.Date_of_Manufacture.MinimumWidth = 8;
            this.Date_of_Manufacture.Name = "Date_of_Manufacture";
            // 
            // wording
            // 
            this.wording.HeaderText = "Wording";
            this.wording.Name = "wording";
            // 
            // marque
            // 
            this.marque.HeaderText = "Marque";
            this.marque.Name = "marque";
            // 
            // id_machine
            // 
            this.id_machine.HeaderText = "id_machine";
            this.id_machine.Name = "id_machine";
            this.id_machine.Visible = false;
            // 
            // id_marque
            // 
            this.id_marque.HeaderText = "id_marque";
            this.id_marque.Name = "id_marque";
            this.id_marque.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MCM.Properties.Resources.d21a76863ebd089e021b229ba443c4df;
            this.panel1.Controls.Add(this.dataGridViewmachine);
            this.panel1.Location = new System.Drawing.Point(106, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 308);
            this.panel1.TabIndex = 145;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(287, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 36);
            this.button3.TabIndex = 140;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MCM.Properties.Resources.d21a76863ebd089e021b229ba443c4df;
            this.ClientSize = new System.Drawing.Size(891, 379);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "Machine";
            this.Text = "Machine";
            this.Load += new System.EventHandler(this.Machine_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARQUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRANettoyageDataSetMarque)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mACHINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRANettoyageDataSetMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmachine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimemachine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savemachine;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button button4;
        private HRRANettoyageDataSetMachine hRRANettoyageDataSetMachine;
        private System.Windows.Forms.BindingSource mACHINEBindingSource;
        private HRRANettoyageDataSetMachineTableAdapters.MACHINETableAdapter mACHINETableAdapter;
        private HRRANettoyageDataSetMarque hRRANettoyageDataSetMarque;
        private System.Windows.Forms.BindingSource mARQUEBindingSource;
        private HRRANettoyageDataSetMarqueTableAdapters.MARQUETableAdapter mARQUETableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewmachine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_Manufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn wording;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_marque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
    }
}