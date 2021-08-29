using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    /* A DbContext instance represents a session with the database 
    and can be used to query and save instances of your entities.*/
    public class TodoContext : DbContext 
    {
        public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems {get; set;}
    }
}
