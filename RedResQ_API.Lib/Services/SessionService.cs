using System;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using RedResQ_API.Lib.Models;

namespace RedResQ_API.Lib.Services
{
    public static class SessionService
    {
        public static Session Login(string username, string email, string password)
        {
            try
            {
                using (var connection = new SqlConnection(Constants.ConnectionString))
                {
                    Console.WriteLine(connection.State);

                    var sql = $"select s.* from VSession as s " +
                              $"left join Person p " +
                              $"on s.PersonID = p.ID " +
                              $"where (s.username = @username or s.email = @email) " +
                              $"and p.password = @password";
                    
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                        connection.Open();
                        
                        var reader = cmd.ExecuteReader();
                        var output = new DataTable();
                        
                        output.Load(reader);
                        
                        connection.Close();

                        if (output.Rows.Count == 1)
                        {
                            Sex sex;
                            var length = output.Rows[0].ItemArray.Length - 1;

                            if (!Enum.TryParse<Sex>(Convert.ToString(output.Rows[0].ItemArray[length - 7]), out sex))
                            {
                                return null;
                            }
                            
                            var loc = new Location(Convert.ToInt32(output.Rows[0].ItemArray[length - 4]), 
                                Convert.ToString(output.Rows[0].ItemArray[length - 3]), 
                                Convert.ToString(output.Rows[0].ItemArray[length - 2]), 
                                Convert.ToString(output.Rows[0].ItemArray[length - 1]), 
                                Convert.ToString(output.Rows[0].ItemArray[length]));
                            
                            var lang = new Language(Convert.ToInt32(output.Rows[0].ItemArray[length - 6]),
                                Convert.ToString(output.Rows[0].ItemArray[length - 5]));

                            var person = new Person(Convert.ToInt32(output.Rows[0].ItemArray[length - 13]),
                                Convert.ToString(output.Rows[0].ItemArray[length - 12]),
                                Convert.ToString(output.Rows[0].ItemArray[length - 11]),
                                Convert.ToString(output.Rows[0].ItemArray[length - 10]),
                                Convert.ToString(output.Rows[0].ItemArray[length - 9]),
                                (DateTime)output.Rows[0].ItemArray[length - 8],
                                sex,
                                lang, loc, null);

                            return new Session(Convert.ToInt32(output.Rows[0].ItemArray[length - 13]),
                                Convert.ToString(output.Rows[0].ItemArray[length - 12]),
                                person);
                        }
                        else
                        {
                            return null;
                        }
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