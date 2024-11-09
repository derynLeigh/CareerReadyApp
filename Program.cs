using System;
using MySql.Data.MySqlClient;
using DotNetEnv;
using CareerReadyApp.Data;

namespace CareerReadyApp
{
    class Program
    {
        static void main(string[] args)
        {
            Env.Load();

            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? throw new InvalidOperationException("Connection string is not set.");

            RunApplication(connectionString);
        
        }

        private static void RunApplication(string connectionString)
        {
            try
            {
                var dataAccess = new DataAccess(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occurred while running the application: {ex.Message}");
            }
        }
    }
}
