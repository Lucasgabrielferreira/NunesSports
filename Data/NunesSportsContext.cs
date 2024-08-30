using Microsoft.EntityFrameworkCore;
using NunesSports.Models;

namespace NunesSports.Data
{
    public class NunesSportsContext : DbContext
    {
        public NunesSportsContext(DbContextOptions<NunesSportsContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
