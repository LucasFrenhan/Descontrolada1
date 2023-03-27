using Descontrolada.Data;
using Descontrolada.Models;
using Descontrolada.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Descontrolada.ProdutoRepositorios;

  public class ProdutoRepositorio : IProdutoRepositorio
  {
      private readonly DescontroladaDBContext _dbContext;
      public ProdutoRepositorio(DescontroladaDBContext descontroladaDBContext)
      {
          _dbContext = descontroladaDBContext;
      }
  public async Task<ProdutoModel> BuscarPorId(Guid id)
    => await _dbContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
  public async Task<List<ProdutoModel>> BuscarTodosProdutos()
    => await _dbContext.Produtos.ToListAsync();
  public async Task<ProdutoModel> AdicionarProduto(ProdutoModel produto)
      {
          await _dbContext.Produtos.AddAsync(produto);
          await _dbContext.SaveChangesAsync();

          return produto;
      }        
  }
