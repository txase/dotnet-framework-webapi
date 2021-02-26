using Microsoft.EntityFrameworkCore;

namespace webapi.Data
{
    public class webapiContext : DbContext
    {
        public webapiContext(): base(webapiConnectionStringBuilder.ConnectionString)
        {
            Database.SetInitializer(new webapiInitializer());
        }

        public System.Data.Entity.DbSet<webapi.Models.Author> Authors
        {
            get;
            set;
        }

        public System.Data.Entity.DbSet<webapi.Models.Book> Books
        {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { /* Use Configuration from static ConfigurationManager to access connection string in appsettings.json. Example below: optionsBuilder.UseSqlServer(ConfigurationManager.Configuration.GetConnectionString("CONNECTIONSTRINGNAME")); */
            base.OnConfiguring(optionsBuilder);
        }
    }
}