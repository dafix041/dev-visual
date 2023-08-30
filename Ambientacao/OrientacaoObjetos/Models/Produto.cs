namespace OrientacaoObjetos.Models;
public class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    public Produto() { }

    public Produto(string? nome, string? descricao, DateTime validade)
    {
        Nome = nome;
        Descricao = descricao;
        Validade = validade;
    }

    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public DateTime Validade { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome} \nValidade: {Validade}";
    }
}
