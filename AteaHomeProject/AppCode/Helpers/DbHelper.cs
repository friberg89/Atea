using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AteaHomeProject.AppCode.Helpers
{
    public class DbHelper
    {
        public static IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ToString());
            connection.Open();
            return connection;
        }
    }
}