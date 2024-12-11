using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ZCLINIC
{
    public static class Connection
    {
        public static IConfiguration _config;
        public static SqlConnection GetConnection()
        {
            SqlConnection FOCon = new SqlConnection();
            FOCon.ConnectionString = _config.GetConnectionString("ZCLINIC");
            return FOCon;
        }

        public static SqlConnection GetLogConnection()
        {
            SqlConnection LogCon = new SqlConnection();
            LogCon.ConnectionString = _config.GetConnectionString("ZCLINIC");
            if(LogCon.State == System.Data.ConnectionState.Closed)
            {
                LogCon.Open();
            }
            return LogCon;
        }
    }
}
