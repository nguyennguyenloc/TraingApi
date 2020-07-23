using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}