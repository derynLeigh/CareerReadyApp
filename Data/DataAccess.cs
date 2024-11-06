using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CareerReadyApp.Data
{
    public class DataAccess
    {
        private readonly DataContext _context;

        public DataAccess(string connectionString)
        {
            _context = new DataContext(connectionString);
        }

        // Methods for adding, updating, deleting books etc. can be added here
    }
}