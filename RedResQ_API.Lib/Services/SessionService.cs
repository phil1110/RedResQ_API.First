using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using RedResQ_API.Lib.Models;

namespace RedResQ_API.Lib.Services
{
    public static class SessionService
    {
        public static object Login(string username, string email, string password)
        {
            try
            {
                using (var connection = new SqlConnection(Constants.ConnectionString))
                {
                    Console.WriteLine(connection.State);

                    var sql = "select * from session";

                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        
                        var reader = cmd.ExecuteReader();
                        var output = new DataTable();
                        
                        output.Load(reader);

                        return JsonConvert.SerializeObject(output);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}