namespace API.Models;
public class Produto
{

    public Produto() => CriadoEm = DateTime.Now;
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    public DateTime CriadoEm { get; set; }


}
