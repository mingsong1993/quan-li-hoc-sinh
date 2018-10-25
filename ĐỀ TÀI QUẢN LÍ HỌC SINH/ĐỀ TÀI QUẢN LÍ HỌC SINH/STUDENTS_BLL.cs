using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    class STUDENTS_BLL
    {
        STUDENTS_DAL dalST;
        public STUDENTS_BLL()
        {
            dalST = new STUDENTS_DAL();
        }
        public DataTable GetAllStudents()
        {
            return dalST.GetAllStudents();
        }
        public bool InsertStudents(tblSTUDENTS st)
        {
            return dalST.InsertStudents(st);
        }
        public bool UpdateStudent(tblSTUDENTS st)
        {
            return dalST.UpdateStudent(st);
        }
        public bool DeleteStudent(tblSTUDENTS st)
        {
            return dalST.DeleteStudent(st);
        }
        public DataTable FindStudent(string st)
        {
            return dalST.FindStudent(st);
        }
    }
}
