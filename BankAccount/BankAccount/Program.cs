using System;
using System.Globalization;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {
            int numeroConta;
            string nome;
            double valorInicial, deposito, saque;
            char inicial;

            Console.Write("Entre o número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            inicial = char.Parse(Console.ReadLine());

            Conta acc = new Conta(nome, numeroConta);
            if (inicial == 's') {
                Console.Write("Entre o valor do depósito inicial: ");
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else {
                valorInicial = 0.00;
            }
            acc.Depositar(valorInicial);
            Console.WriteLine();//quebra de linha

            Console.WriteLine("Dados da conta:\n" + acc);//fazer toString override na classe
            Console.WriteLine();//quebra de linha

            Console.Write("Entre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.Depositar(deposito);
            Console.WriteLine($"Dados da conta atualizados:\n{acc}");//novamente com o toString
            Console.WriteLine();//quebra de linha

            Console.Write("Entre um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.Sacar(saque);
            Console.WriteLine($"Dados da conta atualizados:\n{acc}");//novamente com o toString
        }
    }
}
