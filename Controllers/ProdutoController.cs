using Descontrolada.Models;
using Descontrolada.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Descontrolada.Controllers;

[Route("api/")]
  [ApiController]
  public class ProdutoController : ControllerBase
  {
      private readonly IProdutoRepositorio _produtoRepositorio;

      public ProdutoController(IProdutoRepositorio produtoRepositorio)
      {
          _produtoRepositorio = produtoRepositorio;
      }
      
      [HttpGet("produtos")]
      public async Task<ActionResult<List<ProdutoModel>>> ListarProdutos()
      {
          try 
          {
              List<ProdutoModel> produtos = await _produtoRepositorio.BuscarTodosProdutos();
              return Ok(produtos);
          }
          catch(Exception ex)
          {
              return BadRequest(ex.Message);
          }
          
      }
      
      [HttpGet("produto/{id}")]
      public async Task<ActionResult<ProdutoModel>> ListarProdutoId(Guid id)
      {
          try
          {
              ProdutoModel produto = await _produtoRepositorio.BuscarPorId(id);
              return Ok(produto);
          }
          catch(Exception ex)
          {
              return BadRequest(ex.Message);
          }
          
      }
      
      [HttpPost("cadastrar-produto")]
      public async Task<ActionResult<ProdutoModel>> CadastrarProduto([FromBody] ProdutoModel produtoModel)
      {
          try
          {
              ProdutoModel produto = await _produtoRepositorio.AdicionarProduto(produtoModel);
              return Ok(produto);
          }
          catch(Exception ex)
          {
              return BadRequest(ex.Message);
          }            
      }
  }
