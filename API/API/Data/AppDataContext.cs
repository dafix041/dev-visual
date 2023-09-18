using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options): 
    base(options) 
    { }


//Classes que vão virar tabelas pro banco de dados

public  DbSet<Produto> Produtos { get; set; }
public DbSet<Categoria> Categorias{ get; set; }


}
