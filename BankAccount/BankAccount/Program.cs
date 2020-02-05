using System;
using System.Globalization;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {
            int numeroConta;
            string nome;
            double valor;
            char inicial;

            Console.Write("Entre o número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            inicial = char.Parse(Console.ReadLine());
            if (inicial == 's') {
                Console.Write("Entre o valor do depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
            }
            else {
                valor = 0.00;
            }
            Conta acc = new Conta(nome, numeroConta, valor);

            Console.WriteLine("Dados da conta: ");//fazer tostring override na classe

            Console.Write("Entre um valor para depósito: ");
            Console.ReadLine();
            Console.WriteLine("Dados da conta atualizados: ");//novamente com o toString

            Console.Write("Entre um valor para saque: ");
            Console.ReadLine();
            Console.WriteLine("Dados da conta atualizados: ");//novamente com o toString
        }
    }
}
