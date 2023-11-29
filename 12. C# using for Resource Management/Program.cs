using System;
using System.Data.SqlClient;

namespace _12.C__using_for_Resource_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server = .; Database = EmployeesDB; User Id = sa; Password = sa123456";

            try
            {
                using(SqlConnection connection =  new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    string query = "select EmployeeID, Name from Employees";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int ID = (int)reader["EmployeeID"];
                                    string Name = (string)reader["Name"];
                                    Console.WriteLine($"ID: {ID} , Name : {Name}");
                                }
                            }
                            else
                                Console.WriteLine("No Rows");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
