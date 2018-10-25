namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    partial class FormLOGIN
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
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUSERNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.Location = new System.Drawing.Point(68, 143);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(117, 23);
            this.btnLOGIN.TabIndex = 2;
            this.btnLOGIN.Text = "ĐĂNG NHẬP";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÀI KHOẢN:";
            // 
            // txtUSERNAME
            // 
            this.txtUSERNAME.Location = new System.Drawing.Point(157, 41);
            this.txtUSERNAME.Name = "txtUSERNAME";
            this.txtUSERNAME.Size = new System.Drawing.Size(210, 22);
            this.txtUSERNAME.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MẬT KHẨU:";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(157, 76);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(210, 22);
            this.txtPASSWORD.TabIndex = 1;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(250, 143);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(117, 23);
            this.btnEXIT.TabIndex = 3;
            this.btnEXIT.Text = "THOÁT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // FormLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 225);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtUSERNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnLOGIN);
            this.Name = "FormLOGIN";
            this.Text = "ĐĂNG NHẬP GIÁO VIÊN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUSERNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Button btnEXIT;
    }
}

