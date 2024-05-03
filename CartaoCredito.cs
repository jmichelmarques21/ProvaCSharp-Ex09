using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class CartaoCredito : IMetodoPagamento
    {
        public double valor;
        public string dataPedido = "";

        public void aprovaPagamento(){
            if (this.valor > 0) {
                System.Console.WriteLine("Pagamento aprovado!");
            } else {
                System.Console.WriteLine("Pagamento não aprovado!");
            }
        }
        public void formaPagamento(){
            System.Console.WriteLine("A forma de pagamento escolhida foi Cartão de crédito!");
        }
        
    }
}