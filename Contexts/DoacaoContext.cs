using DoacoesICCPVU.Models;
using Microsoft.EntityFrameworkCore;

namespace DoacoesICCPVU.Contexts
{
    public class DoacaoContext : DbContext
    {
        public DbSet<Doacao> Doacoes => Set<Doacao>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=doacoes.sqlite3");
        }
    }
}
