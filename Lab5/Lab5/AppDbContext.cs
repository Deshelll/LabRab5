using Microsoft.EntityFrameworkCore;

namespace Lab5
{

    public class AppDbContext : DbContext
    {
        public DbSet<FileModel> Files { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public int a = 5;
        public string b = "hello";
    }

}
