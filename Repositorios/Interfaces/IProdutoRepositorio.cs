using Descontrolada.Models;

namespace Descontrolada.Repositorios.Interfaces;

  public interface IProdutoRepositorio
  {
      Task<List<ProdutoModel>> BuscarTodosProdutos();
      Task<ProdutoModel> BuscarPorId(Guid Id);
      Task<ProdutoModel> AdicionarProduto(ProdutoModel produto);
  }
