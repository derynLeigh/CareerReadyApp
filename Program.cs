using System;
using MySql.Data.MySqlClient;

namespace CareerReadyApp
{
    class Program
    {
        static void main(string[] args)
        {
            string connectionString = "Server=localhost;Database=thelist;User ID=root;Password=Pass1234!;";

            using (var connection = new MySqlConnection(connectionString))
            {
                try{
                    connection.Open();
                    Console.WriteLine("We are the Borg.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Resistance is futile: {ex.Message}");
                }
            }
        }
    }
}
