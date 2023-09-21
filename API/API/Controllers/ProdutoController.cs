using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API;
[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    private readonly AppDataContext _ctx;
    public ProdutoController(AppDataContext ctx)
    {
        _ctx = ctx;
    }
    private static List<Produto> produtos = new List<Produto>();


    //GET: api/produto/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar() =>

     _ctx.Produtos.ToList().Count == 0 ? NotFound() : Ok(_ctx.Produtos.ToList());



    //GET: api/produto/buscar/bolacha{}
    [HttpGet]
    [Route("buscar/{nome}")]
    public IActionResult Buscar([FromRoute] string nome)
    {
        foreach (Produto produtoCadastrado in produtos)
        {
            if (produtoCadastrado.Nome == nome)
            {
                return Ok(produtoCadastrado);
            }
        }
        return NotFound();
    }
    //POST: api/produto/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Produto produto)
    {
        _ctx.Produtos.Add(produto);
        _ctx.SaveChanges();
        return Created("", produto);
    }

  [HttpDelete]
    [Route("deletar/id")]
    public IActionResult Deletar([FromRoute] int id){
        Produto produto = _ctx.Produtos.Find(id);
        if(produto == null)
        {
            return NotFound();
        }
       _ctx.Produtos.Remove(produto);
       _ctx.SaveChanges();
       return Ok();
    }

    




}

// if(produtos.Count == 0){

//     return NotFound();
// }
// return Ok(produtos);