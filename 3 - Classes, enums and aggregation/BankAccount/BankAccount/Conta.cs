using System;
using System.Globalization;

namespace BankAccount {
    class Conta {

        public string Nome { get; set; }
        public int NumeroConta { get;  private set; }
        public double Valor { get; private set; }
        public double TaxaSaque { get; private set; }

        public Conta(string nome, int numeroConta) {
            Nome = nome;
            NumeroConta = numeroConta;
            Valor = 0.00;
            TaxaSaque = 5.00;
        }

        public void Depositar(double deposito) {
            Valor += deposito;
        }

        public void Sacar(double saque) {
            Valor -= (saque + TaxaSaque);
        }

        public override string ToString() {
            return "Conta: "
                    + NumeroConta
                    + ", Titular: "
                    + Nome
                    + ", Saldo: R$"
                    + Valor.ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}
