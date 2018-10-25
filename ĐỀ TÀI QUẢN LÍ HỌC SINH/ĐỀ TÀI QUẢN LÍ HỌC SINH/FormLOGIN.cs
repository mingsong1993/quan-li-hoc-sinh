using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    public partial class FormLOGIN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DRAKONFLY\SQLEXPRESS;Initial Catalog=DE_TAI_QUAN_LI_HOC_SINH;User ID=sa;Password=123");
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string sql = "select *from LOGIN where USERNAME = '"+txtUSERNAME.Text+"' and PASSWORD = '"+txtPASSWORD.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chuyển tab tại đây
                    {
                        FormSTUDENTS fs = new FormSTUDENTS();
                        fs.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
                Application.Exit();
        }
    }
}
