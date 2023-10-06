using System.Data;
using System.Data.SqlClient;

namespace RedResQ_API.Lib
{
    public class SqlHandler
    {
        private Settings _settings;
        private SqlConnectionStringBuilder _builder;

        public SqlHandler()
        {
            _settings = new Settings();
            _builder = new SqlConnectionStringBuilder();

        }

        private SqlCredential ReadCredentials()
        {
            return null;
        }
    }
}