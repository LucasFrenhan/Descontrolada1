using Descontrolada.Data.Map;
using Descontrolada.Models;
using Microsoft.EntityFrameworkCore;

namespace Descontrolada.Data
{
    public class DescontroladaDBContext : DbContext
    {
        public DescontroladaDBContext(DbContextOptions<DescontroladaDBContext> options)
        : base(options)
        {
            
        }
        public DbSet<ProdutoModel> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
