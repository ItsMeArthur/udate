using Microsoft.EntityFrameworkCore;
using UDate.API.Models;

namespace UDate.API.Data
{
    // We must inherit from DbContext, as it represents a Database.
    public class DataContext : DbContext
    {
        // Throut the DbContextOptions we can set the connection string and
        // other information regarding the connection with the database.
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        // Create an object that represents tables of Values.
        public DbSet<Value> Values {get;set;}
    }
}