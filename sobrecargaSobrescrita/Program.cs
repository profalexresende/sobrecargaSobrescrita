// See https://aka.ms/new-console-template for more information
using sobrecargaSobrescrita;

ContaCorrente contaCorrente = new ContaCorrente();
ContaPoupanca contaPoupanca = new ContaPoupanca();
double valor = 0;

while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Depositar na Conta Corrente");
    Console.WriteLine("2. Sacar da Conta Corrente");
    Console.WriteLine("3. Depositar na Conta Poupança");
    Console.WriteLine("4. Sacar da Conta Poupança");
    Console.WriteLine("5. Calcular Juros da Conta Corrente");
    Console.WriteLine("6. Calcular Rendimento da Poupança");
    Console.WriteLine("7. Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite o valor a depositar na Conta Corrente: ");
            valor = Convert.ToDouble(Console.ReadLine());
            contaCorrente.Depositar(valor);
            break;

        case "2":
            Console.Write("Digite o valor a sacar da Conta Corrente: ");
            valor = Convert.ToDouble(Console.ReadLine());
            contaCorrente.Sacar(valor);
            break;

        case "3":
            Console.Write("Digite o valor a depositar na Conta Poupança: ");
            valor = Convert.ToDouble(Console.ReadLine());
            contaPoupanca.Depositar(valor);
            break;

        case "4":
            Console.Write("Digite o valor a sacar da Conta Poupança: ");
            valor = Convert.ToDouble(Console.ReadLine());
            contaPoupanca.Sacar(valor);
            break;
        case "5":
            valor = 0;
            Console.Write("Digite a taxa de juros ou 0 para taxa base: ");
            valor = Convert.ToDouble(Console.ReadLine());
            if (valor == 0)
            {
                contaCorrente.CalcularJuros();
            }
            else
            {
                contaCorrente.CalcularJuros(valor);
            }
            break;
        case "6":
            contaPoupanca.CalcularJuros();
            break;
        case "7":
            Console.WriteLine("Saindo do programa.");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine(); // Adiciona uma linha em branco para melhor legibilidade
}
