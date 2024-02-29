using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaSobrescrita
{
    abstract class Conta
    {
        public double Saldo { get; set; }

        public virtual void Depositar(double valor)
        {
            Console.WriteLine("Método depositar da classe conta");
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado. Novo saldo: {Saldo}");
        }

        public virtual void Sacar(double valor)
        {
            Console.WriteLine("Método sacar da classe conta");
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Novo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public virtual void CalcularJuros()
        {
            Console.WriteLine("Método calcularJuros da classe conta");
            //Supondo um juros base de 10%
            Saldo = Saldo - (Saldo * 0.1);
            Console.WriteLine($"Juros Aplicados. Novo saldo: {Saldo}");
        }
    }
}
