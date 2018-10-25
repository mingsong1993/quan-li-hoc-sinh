using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    class ClassMANAGE_DATA
    {
        //tạo một biến connection sql
        SqlConnection conn = new SqlConnection(@"Data Source=DRAKONFLY\SQLEXPRESS;Initial Catalog=DE_TAI_QUAN_LI_HOC_SINH;User ID=sa;Password=123");

        //hàm mở kết nối sql
        private void openconnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //hàm đóng kết nối sql
        private void closeconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //hàm thực thi dữ liệu CUD vào data
        public Boolean exedata(string cmd)
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }

        //hàm đọc dữ liệu từ data
        public DataTable readdata(string cmd)
        {
            openconnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            closeconnect();
            return da;
        }


    }
}
