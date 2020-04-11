using System.Collections.Generic;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnection(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - call sql database
                SqlConnection sql = new SqlConnection();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                // TODO - call text files
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}



/// Here we implimented global settings because we are using 2 data sources. We can add 3rd db soruce like Mysql as well.