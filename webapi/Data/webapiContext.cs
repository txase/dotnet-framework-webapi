using System.Data.Entity;

namespace webapi.Data
{
    public class webapiContext : DbContext
    {
        public webapiContext() : base(webapiConnectionStringBuilder.ConnectionString)
        {
            Database.SetInitializer(new webapiInitializer());
        }

        public System.Data.Entity.DbSet<webapi.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<webapi.Models.Book> Books { get; set; }
    }
}
