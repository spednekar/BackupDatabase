using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace BackupDatabase
{
    public static class BackupDatabase
    {
        static string backupFolder = ConfigurationManager.AppSettings["BackupFolder"];

        static BackupDatabase()
        {
            if (!Directory.Exists(backupFolder))
                Directory.CreateDirectory(backupFolder);
        }

        public static void Backup()
        {
            foreach (ConnectionStringSettings connectionString in ConfigurationManager.ConnectionStrings)
            {
                try
                {
                    var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString.ConnectionString);

                    if (string.IsNullOrWhiteSpace(sqlConStrBuilder.InitialCatalog))
                        continue;

                    var backupFileName = String.Format("{0}{1}-{2}.bak",
                        backupFolder, sqlConStrBuilder.InitialCatalog,
                        DateTime.Now.ToString("yyyy-MM-dd"));

                    using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
                    {
                        var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'",
                            sqlConStrBuilder.InitialCatalog, backupFileName);

                        using (var command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex);
                }
            }
        }
    }
}
