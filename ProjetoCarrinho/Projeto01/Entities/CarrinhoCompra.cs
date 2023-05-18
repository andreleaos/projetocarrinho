using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities;

public class CarrinhoCompra
{
    private List<Produto> _items = null;

    public CarrinhoCompra()
    {
        _items = new List<Produto>();
    }

    public void AdicionarItem(Produto produto)
    {
        _items.Add(produto);
    }

    public void RemoverItem(Produto produto)
    {
        _items.Remove(produto);
    }

    public double ExibirValorCompra()
    {
        double result = _items.Sum(p => p.Valor);
        return result;
    }

}
