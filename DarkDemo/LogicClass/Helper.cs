using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public static class Helper
    {
        public static string GetConnectionString(String dbName)
        {
            return ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }
        public static string GetComMailInfo(string infoType)
        {
            return ConfigurationManager.AppSettings[infoType];
        }

        public static string GetComMailPassword(string infoType)
        {
            return ConfigurationManager.AppSettings[infoType];
        }


    }
}
