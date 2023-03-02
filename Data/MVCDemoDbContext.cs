using Microsoft.EntityFrameworkCore;
using MVCProjectApp.Models.Domain;

namespace MVCProjectApp.Data
{
        /*
         * This DbContext class provides an interface
         * that allows us to mapp object to database tables
         * it provides methods for us, etc...
         * Think of it like the repository class in Spring Boot
         */

    public class MVCDemoDbContext : DbContext
    {
        //Options is our configuration, it's what dbContext will configure to, IE what it needs to connect to a particular database
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
