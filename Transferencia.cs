using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class Transferencia
    {
        public double valor;
        public int horas;

        public void aprovaPagamento(){
            if (this.valor == 0 && this.horas > 6) {
                System.Console.WriteLine("Pagamento não aprovado!");
            } else {
                System.Console.WriteLine("Pagamento aprovado!");
            }
        }

        public void formaPagamento(){
            System.Console.WriteLine("A forma de pagamento escolhida foi transferência bancária!");
        }
    }
}