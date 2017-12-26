using System.Data.Entity;

namespace SQLite
{
    public class SqliteContext : DbContext
    {
        public SqliteContext() : base("SqliteContext")
        {
            Database.SetInitializer<SqliteContext>(null);
        }

        public DbSet<Person> Person { get; set; }
    }
}
