using Microsoft.EntityFrameworkCore;

namespace GCarvalho.Data.Conf
{
    public class LuthieriaContext : DbContext
    {
        public LuthieriaContext(DbContextOptions<LuthieriaContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<Instrumento> Instrumentos { get; set; }

    }
}
