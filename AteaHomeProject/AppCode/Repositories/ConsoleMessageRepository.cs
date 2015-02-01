using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AteaHomeProject.AppCode.Helpers;
using AteaHomeProject.Models;
using Dapper;

namespace AteaHomeProject.AppCode.Repositories
{
    public class ConsoleMessageRepository
    {
        public static List<ConsoleMessage> GetAll()
        {
            using (var conn = DbHelper.GetConnection())
            {
                try
                {
                    return conn.Query<ConsoleMessage>("SELECT * FROM ConsoleMessage ORDER BY Date DESC").ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}