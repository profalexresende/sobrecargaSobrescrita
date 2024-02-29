using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaSobrescrita
{
    class ContaPoupanca: Conta
    {
        public ContaPoupanca() { }
        public ContaPoupanca (double saldo)
        {
            Saldo = saldo;  
        }
        public override void CalcularJuros()
        {
            //Supondo um rendimento de 1%
            Console.WriteLine("Calculando juros da conta poupança.");
            Saldo = Saldo * 1.01;
            Console.WriteLine($"Rendimento Aplicado. Novo saldo: {Saldo}");
        }
    }
}
