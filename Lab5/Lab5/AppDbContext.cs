namespace Test2
{
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public DbSet<FileModel> Files { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }

}
