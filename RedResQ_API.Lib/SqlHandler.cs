using System.Data;
using System.Data.SqlClient;

namespace RedResQ_API.Lib
{
    public class SqlHandler
    {
        private SqlConnectionStringBuilder _builder;

        public SqlHandler()
        {
            _builder = new SqlConnectionStringBuilder();

        }
    }
}