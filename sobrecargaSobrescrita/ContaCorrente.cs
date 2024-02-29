using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaSobrescrita
{
    class ContaCorrente:Conta
    {
        public double limiteEspecial { get; set; }
        public ContaCorrente() 
        {
            limiteEspecial = 1000;
        }
        public ContaCorrente(double limiteEspecial,double saldo)
        {
            this.limiteEspecial = limiteEspecial;
            this.Saldo = saldo;
        }

        public override void Sacar(double valor)
        {
            Console.WriteLine("Método sacar da classe conta corrente");
            if (valor < limiteEspecial + Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Novo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public void CalcularJuros(double taxa)
        {
            Console.WriteLine("Método calcularJuros da classe conta corrente");
            Console.WriteLine("Calculando juros da conta corrente.");
            Saldo = Saldo - (Saldo * (taxa / 100));
            Console.WriteLine($"Juros Aplicados. Novo saldo: {Saldo}");
        }

    }
}
