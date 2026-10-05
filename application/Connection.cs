using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace application
{
    internal class Connection
    {
        public static MySqlConnection GetConnection()
        {
            String host = Environment.GetEnvironmentVariable("DB_HOST");
            String database = Environment.GetEnvironmentVariable("DB_NAME");
            String port = Environment.GetEnvironmentVariable("DB_PORT");
            String uid = Environment.GetEnvironmentVariable("DB_USER");
            String pwd = Environment.GetEnvironmentVariable("DB_PASSWORD");

            string connectionString = $"server={host};port={port};database={database};uid={uid};pwd={pwd}";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos", ex);
            }
        }
    }
}
