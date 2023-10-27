using System.Data.SqlClient;

namespace RedResQ_API.Lib
{
    public static class Constants
    {
        public const int SessionValidity = 30;

        static Constants()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "localhost",
                UserID = "api",
                Password = "password",
                InitialCatalog = "RedResQ"
            };
            
            ConnectionString = builder.ConnectionString;
        }

        public static string ConnectionString { get; private set; }
    }
}