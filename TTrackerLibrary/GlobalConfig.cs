using System.Collections.Generic;
using System.Configuration;
using TTrackerLibrary;
using TTrackerLibrary.DataAccess.TextHelpers;

namespace TTrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }
        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.sql)
            {
                SqlConnection sql = new SqlConnection();
                Connections = sql;
            }
            if (db == DatabaseType.textFile)
            {
                TextConnection text = new TextConnection();
                Connections = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}