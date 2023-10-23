using System.Data.SqlClient;

namespace RedResQ_API.Lib
{
    public static class Constants
    {
        public const int SessionValidity = 30;
        public static readonly string ConnectionString;
        
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
    }
}