using Microsoft.EntityFrameworkCore;

namespace PFA.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Candidat> Candidats { get; set; }
    }
}