using Microsoft.EntityFrameworkCore;

namespace core.test
{
    internal class SqlServerContext : DbContext
    {
         public SqlServerContext(DbContextOptions<SqlServerContext> options): base(options)
    {
    }

    public DbSet<SqlServerContext> TodoItems { get; set; }
}
}