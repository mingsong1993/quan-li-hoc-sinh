using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỀ_TÀI_QUẢN_LÍ_HỌC_SINH
{
    class DataConnection
    {
        String conStr;
        public DataConnection()
        {
            conStr = "Data Source = DRAKONFLY\\SQLEXPRESS; Initial Catalog=DE_TAI_QUAN_LI_HOC_SINH; UID=sa; PWD=123";
        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
