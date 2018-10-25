using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    public partial class FormSTUDENTS : Form
    {
        STUDENTS_BLL bllST;
        public FormSTUDENTS()
        {
            InitializeComponent();
            bllST = new STUDENTS_BLL();
        }

        public void ShowAllStudents()
        {
            DataTable dt = bllST.GetAllStudents();
            dataGridViewStudents.DataSource = dt;
        }

        private void FormSTUDENTS_Load(object sender, EventArgs e)
        {
            //combobox default load
            comboBoxGENDER.SelectedIndex = 0;
            comboBoxGRADE.SelectedIndex = 0;
            ShowAllStudents();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtFULLNAME.Text))
            {
                MessageBox.Show("Bạn chưa nhập Họ và Tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFULLNAME.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("Bạn chưa nhập Email học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEMAIL.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtADDRESS.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtADDRESS.Focus();
                return false;
            }
            return true;
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblSTUDENTS st = new tblSTUDENTS();
                st.STUDENT_ID = txtSTUDENT_ID.Text;
                st.FULLNAME = txtFULLNAME.Text;
                st.BIRTHDATE = timePikerBIRTHDATE.Value.ToString();
                st.GENDER = comboBoxGENDER.Text;
                st.GRADE = comboBoxGRADE.Text;
                st.EMAIL = txtEMAIL.Text;
                st.ADDRESS = txtADDRESS.Text;

                if (bllST.InsertStudents(st))
                {
                    ShowAllStudents();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblSTUDENTS st = new tblSTUDENTS();
                st.STUDENT_ID = txtSTUDENT_ID.Text;
                st.FULLNAME = txtFULLNAME.Text;
                st.BIRTHDATE = timePikerBIRTHDATE.Value.ToString();
                st.GENDER = comboBoxGENDER.Text;
                st.GRADE = comboBoxGRADE.Text;
                st.EMAIL = txtEMAIL.Text;
                st.ADDRESS = txtADDRESS.Text;

                if (bllST.UpdateStudent(st))
                {
                    ShowAllStudents();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa hay không?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tblSTUDENTS st = new tblSTUDENTS();
                st.STUDENT_ID = txtSTUDENT_ID.Text;
                if (bllST.DeleteStudent(st))
                {
                    ShowAllStudents();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            //trở về màn hình main
        }
        
        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                //NHỚ SỬA LẠI STUDENT_ID MÃ TỰ TĂNG KHÔNG NHẬP VÀO
                txtSTUDENT_ID.Text = dataGridViewStudents.Rows[index].Cells["STUDENT_ID"].Value.ToString();
                txtFULLNAME.Text = dataGridViewStudents.Rows[index].Cells["FULLNAME"].Value.ToString();
                timePikerBIRTHDATE.Value = DateTime.Parse(dataGridViewStudents.Rows[index].Cells["BIRTHDATE"].Value.ToString());
                comboBoxGENDER.Text = dataGridViewStudents.Rows[index].Cells["GENDER"].Value.ToString();
                comboBoxGRADE.Text = dataGridViewStudents.Rows[index].Cells["GRADE"].Value.ToString();
                txtEMAIL.Text = dataGridViewStudents.Rows[index].Cells["EMAIL"].Value.ToString();
                txtADDRESS.Text = dataGridViewStudents.Rows[index].Cells["ADDRESS"].Value.ToString();
            }
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            string value = txtSEARCH.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllST.FindStudent(value);
                dataGridViewStudents.DataSource = dt;
            }
            else
            {
                ShowAllStudents();
            }
        }
    }
}
