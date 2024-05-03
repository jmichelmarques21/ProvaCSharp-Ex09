using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class Boleto : IMetodoPagamento
    {
        public int diasCompensacao;
        public double valor;

        public void aprovaPagamento() {
            if (this.diasCompensacao > 2 && this.valor == 0){
                System.Console.WriteLine("Pagamento não aprovado!");
            } else {
                System.Console.WriteLine("Pagamento aprovado!");
            }
        }        
        public void formaPagamento(){
            System.Console.WriteLine("A forma de pagamento escolhida foi Boleto Bancário!");
        }
    }
}