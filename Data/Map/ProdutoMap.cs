using Descontrolada.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Descontrolada.Data.Map;

  public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
  {
      public void Configure(EntityTypeBuilder<ProdutoModel> builder)
      {
          builder.HasKey(x => x.Id);
          builder.Property(x => x.TipoProduto).IsRequired();
      }
  }
