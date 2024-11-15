using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC.Model
{
    public class LogSQLDBBusiness
    {
        public DataTable GetSQLData(string query)
        {
            DataTable tbl = new DataTable();
            tbl = SqlConnect_10_118_11_111.GetData(query);
            return tbl;
        }
        public bool ExcuteSQLQuery(string query)
        {
            try
            {
                SqlConnect_10_118_11_111.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return SqlConnect_10_118_11_111.Error;
        }
    }
}
