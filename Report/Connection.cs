using System.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Report
{
    public static class Connection
    {
        public static SqlConnection Con;
        public static SqlConnection LogCon;
        public static SqlConnection GetConnection()
        {
            if (Con == null)
            {
                Con = new SqlConnection();
                Con.ConnectionString = ConfigurationManager.ConnectionStrings["FOERP"].ToString();
            }
            if (Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }
            return Con;
        }
        public static SqlConnection GetLogConnection()
        {
            if (LogCon == null)
            {
                LogCon = new SqlConnection();
                LogCon.ConnectionString = ConfigurationManager.ConnectionStrings["FOERP_Log"].ToString();
            }
            if (LogCon.State == System.Data.ConnectionState.Closed)
            {
                LogCon.Open();
            }
            return LogCon;
        }
    }
}
