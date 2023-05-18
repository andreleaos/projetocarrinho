using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Produto
    {
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Qtde { get; set; }
        public double Valor 
        {
            get {
                return Qtde * Preco;
            }
        }
    }
}
