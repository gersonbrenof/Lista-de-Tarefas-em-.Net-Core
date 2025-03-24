using ListaDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }

        // Construtor sem parâmetros para suportar migrações
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=ListaDeTarefas.db");
            }
        }
    }
}
