using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BankAccount {
    class Conta {

        private string _nome;
        public int NumeroConta { get; set; }
        public double Valor { get; private set; }
        public double TaxaSaque { get; private set; }

        public Conta(string nome, int numeroConta) {
            _nome = nome;
            NumeroConta = numeroConta;
            Valor = 0.00;
            TaxaSaque = 5.00;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
                else {
                    Console.WriteLine("Você infomou um nome inválido");//colocar timer para fechar a aplicação
                }
            }
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
