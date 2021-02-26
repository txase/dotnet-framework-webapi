using Microsoft.EntityFrameworkCore;

namespace webapi.Data
{
    public class webapiContext : DbContext
    {
        public DbSet<webapi.Models.Author> Authors
        {
            get;
            set;
        }

        public DbSet<webapi.Models.Book> Books
        {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { /* Use Configuration from static ConfigurationManager to access connection string in appsettings.json. Example below: optionsBuilder.UseSqlServer(ConfigurationManager.Configuration.GetConnectionString("CONNECTIONSTRINGNAME")); */
            optionsBuilder.UseSqlServer(webapiConnectionStringBuilder.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}