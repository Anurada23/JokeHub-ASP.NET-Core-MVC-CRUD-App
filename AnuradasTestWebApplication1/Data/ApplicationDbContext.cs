using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AnuradasTestWebApplication1.Models;

namespace AnuradasTestWebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AnuradasTestWebApplication1.Models.Jokes> Jokes { get; set; } = default!;
    }
}
