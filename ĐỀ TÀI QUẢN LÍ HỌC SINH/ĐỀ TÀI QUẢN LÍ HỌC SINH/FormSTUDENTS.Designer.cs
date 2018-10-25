namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    partial class FormSTUDENTS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSTUDENT_ID = new System.Windows.Forms.TextBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnBACK = new System.Windows.Forms.Button();
            this.comboBoxGENDER = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFULLNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGRADE = new System.Windows.Forms.ComboBox();
            this.timePikerBIRTHDATE = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnINSERT = new System.Windows.Forms.Button();
            this.STUDENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ HỌC SINH:";
            // 
            // txtSTUDENT_ID
            // 
            this.txtSTUDENT_ID.Location = new System.Drawing.Point(143, 30);
            this.txtSTUDENT_ID.Name = "txtSTUDENT_ID";
            this.txtSTUDENT_ID.Size = new System.Drawing.Size(121, 22);
            this.txtSTUDENT_ID.TabIndex = 0;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STUDENT_ID,
            this.FULLNAME,
            this.BIRTHDATE,
            this.GENDER,
            this.GRADE,
            this.EMAIL,
            this.ADDRESS});
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 343);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1093, 269);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(1030, 314);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(75, 23);
            this.btnBACK.TabIndex = 11;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // comboBoxGENDER
            // 
            this.comboBoxGENDER.FormattingEnabled = true;
            this.comboBoxGENDER.Items.AddRange(new object[] {
            "NAM",
            "NỮ"});
            this.comboBoxGENDER.Location = new System.Drawing.Point(143, 124);
            this.comboBoxGENDER.Name = "comboBoxGENDER";
            this.comboBoxGENDER.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGENDER.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "HỌ VÀ TÊN:";
            // 
            // txtFULLNAME
            // 
            this.txtFULLNAME.Location = new System.Drawing.Point(143, 63);
            this.txtFULLNAME.Name = "txtFULLNAME";
            this.txtFULLNAME.Size = new System.Drawing.Size(540, 22);
            this.txtFULLNAME.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "GIỚI TÍNH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "LỚP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "EMAIL:";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(143, 188);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(540, 22);
            this.txtEMAIL.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ĐỊA CHỈ:";
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Location = new System.Drawing.Point(143, 219);
            this.txtADDRESS.Multiline = true;
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtADDRESS.Size = new System.Drawing.Size(540, 57);
            this.txtADDRESS.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "NGÀY SINH:";
            // 
            // comboBoxGRADE
            // 
            this.comboBoxGRADE.FormattingEnabled = true;
            this.comboBoxGRADE.Items.AddRange(new object[] {
            "10A1",
            "10A2",
            "10A3",
            "10A4",
            "11A1",
            "11A2",
            "11A3",
            "12A1",
            "12A2"});
            this.comboBoxGRADE.Location = new System.Drawing.Point(143, 155);
            this.comboBoxGRADE.Name = "comboBoxGRADE";
            this.comboBoxGRADE.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGRADE.TabIndex = 4;
            // 
            // timePikerBIRTHDATE
            // 
            this.timePikerBIRTHDATE.CustomFormat = "MM/dd/yyyy";
            this.timePikerBIRTHDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePikerBIRTHDATE.Location = new System.Drawing.Point(143, 92);
            this.timePikerBIRTHDATE.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.timePikerBIRTHDATE.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.timePikerBIRTHDATE.Name = "timePikerBIRTHDATE";
            this.timePikerBIRTHDATE.Size = new System.Drawing.Size(121, 22);
            this.timePikerBIRTHDATE.TabIndex = 2;
            this.timePikerBIRTHDATE.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "SEARCH:";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Location = new System.Drawing.Point(143, 286);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(540, 22);
            this.txtSEARCH.TabIndex = 10;
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(870, 314);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(75, 23);
            this.btnUPDATE.TabIndex = 8;
            this.btnUPDATE.Text = "SỬA";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(949, 314);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 9;
            this.btnDELETE.Text = "XÓA";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnINSERT
            // 
            this.btnINSERT.Location = new System.Drawing.Point(787, 314);
            this.btnINSERT.Name = "btnINSERT";
            this.btnINSERT.Size = new System.Drawing.Size(75, 23);
            this.btnINSERT.TabIndex = 7;
            this.btnINSERT.Text = "THÊM";
            this.btnINSERT.UseVisualStyleBackColor = true;
            this.btnINSERT.Click += new System.EventHandler(this.btnINSERT_Click);
            // 
            // STUDENT_ID
            // 
            this.STUDENT_ID.DataPropertyName = "STUDENT_ID";
            this.STUDENT_ID.HeaderText = "MÃ HỌC SINH";
            this.STUDENT_ID.Name = "STUDENT_ID";
            this.STUDENT_ID.Width = 50;
            // 
            // FULLNAME
            // 
            this.FULLNAME.DataPropertyName = "FULLNAME";
            this.FULLNAME.HeaderText = "HỌ VÀ TÊN";
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Width = 200;
            // 
            // BIRTHDATE
            // 
            this.BIRTHDATE.DataPropertyName = "BIRTHDATE";
            this.BIRTHDATE.HeaderText = "NGÀY SINH";
            this.BIRTHDATE.Name = "BIRTHDATE";
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "GENDER";
            this.GENDER.HeaderText = "GIỚI TÍNH";
            this.GENDER.Name = "GENDER";
            this.GENDER.Width = 50;
            // 
            // GRADE
            // 
            this.GRADE.DataPropertyName = "GRADE";
            this.GRADE.HeaderText = "LỚP";
            this.GRADE.Name = "GRADE";
            this.GRADE.Width = 50;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 200;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "ĐỊA CHỈ";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Width = 400;
            // 
            // FormSTUDENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 624);
            this.Controls.Add(this.timePikerBIRTHDATE);
            this.Controls.Add(this.comboBoxGRADE);
            this.Controls.Add(this.comboBoxGENDER);
            this.Controls.Add(this.btnINSERT);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtFULLNAME);
            this.Controls.Add(this.txtSTUDENT_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSTUDENTS";
            this.Text = "QUẢN LÍ HỌC SINH";
            this.Load += new System.EventHandler(this.FormSTUDENTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSTUDENT_ID;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.ComboBox comboBoxGENDER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFULLNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGRADE;
        private System.Windows.Forms.DateTimePicker timePikerBIRTHDATE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnINSERT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
    }
}