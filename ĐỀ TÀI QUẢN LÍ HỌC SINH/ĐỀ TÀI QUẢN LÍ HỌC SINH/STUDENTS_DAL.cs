using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    class STUDENTS_DAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public STUDENTS_DAL()
        {
            dc = new DataConnection();
        }
        public DataTable GetAllStudents()
        {
            string sql = "select * from STUDENTS";
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertStudents(tblSTUDENTS st)
        {
            //NHỚ SỬA LẠI STUDENT_ID LÀ MÃ TỰ TĂNG KHÔNG NHẬP VÀO
            string sql = "insert into STUDENTS(STUDENT_ID, FULLNAME, BIRTHDATE, GENDER, GRADE, EMAIL, ADDRESS) values(@STUDENT_ID, @FULLNAME, @BIRTHDATE, @GENDER, @GRADE, @EMAIL, @ADDRESS)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@STUDENT_ID", SqlDbType.VarChar).Value = st.STUDENT_ID;
                cmd.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = st.FULLNAME;
                cmd.Parameters.Add("@BIRTHDATE", SqlDbType.Date).Value = st.BIRTHDATE;
                cmd.Parameters.Add("@GENDER", SqlDbType.NVarChar).Value = st.GENDER;
                cmd.Parameters.Add("@GRADE", SqlDbType.VarChar).Value = st.GRADE;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = st.EMAIL;
                cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar).Value = st.ADDRESS;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool UpdateStudent(tblSTUDENTS st)
        {
            string sql = "update STUDENTS set FULLNAME=@FULLNAME, BIRTHDATE=@BIRTHDATE, GENDER=@GENDER, GRADE=@GRADE, EMAIL=@EMAIL, ADDRESS=@ADDRESS where STUDENT_ID=@STUDENT_ID";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@STUDENT_ID", SqlDbType.VarChar).Value = st.STUDENT_ID;
                cmd.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = st.FULLNAME;
                cmd.Parameters.Add("@BIRTHDATE", SqlDbType.Date).Value = st.BIRTHDATE;
                cmd.Parameters.Add("@GENDER", SqlDbType.NVarChar).Value = st.GENDER;
                cmd.Parameters.Add("@GRADE", SqlDbType.VarChar).Value = st.GRADE;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = st.EMAIL;
                cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar).Value = st.ADDRESS;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool DeleteStudent(tblSTUDENTS st)
        {
            string sql = "delete from STUDENTS where STUDENT_ID=@STUDENT_ID";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@STUDENT_ID", SqlDbType.VarChar).Value = st.STUDENT_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable FindStudent(string st)
        {
            string sql = "select * from STUDENTS where FULLNAME like N'%" + st + "%' or GRADE like '%" +st+ "%' or STUDENT_ID like '%" +st+ "%' or ADDRESS like N'%" +st+ "%'";
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
