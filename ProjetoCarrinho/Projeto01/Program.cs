using Projeto01.Entities;

namespace Projeto01;

internal class Program
{
    static void Main(string[] args)
    {
        CarrinhoCompra carrinho = new CarrinhoCompra();

        Produto produto1 = new Produto() { 
            Descricao = "Mouse Gamer Xpto Bubles", 
            Qtde = 1, 
            Preco = 39.90
        };

        Produto produto2 = new Produto()
        {
            Descricao = "Teclado Gamer Xpto Bubles",
            Qtde = 1,
            Preco = 169.90
        };


        carrinho.AdicionarItem(produto1);
        carrinho.AdicionarItem(produto2);

        double valorCompra = carrinho.ExibirValorCompra();
        Console.WriteLine($"O valor da compra foi de: R$ {valorCompra}");
    }
}