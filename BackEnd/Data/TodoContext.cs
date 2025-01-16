using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) {}

        public DbSet<Task> Task {get; set;}
    }
}