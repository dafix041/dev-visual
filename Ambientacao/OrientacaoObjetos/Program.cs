using OrientacaoObjetos.Models;

// Pessoa pessoa = new Pessoa();
// pessoa.setNome("Diogo");
// Console.WriteLine(pessoa.getNome());

Produto produto = new Produto();

produto.Nome = "Bolacha";

Console.WriteLine(produto.Nome);

Produto produto2 = new Produto
{
    Nome = "Arroz",
    Descricao = "Alimento",
    Validade = DateTime.Now
};

Console.WriteLine(produto2);
