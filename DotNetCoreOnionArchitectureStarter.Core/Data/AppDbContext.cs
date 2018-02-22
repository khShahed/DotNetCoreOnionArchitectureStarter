using DotNetCoreOnionArchitectureStarter.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreOnionArchitectureStarter.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}