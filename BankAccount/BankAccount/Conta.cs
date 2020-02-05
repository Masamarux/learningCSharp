using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount {
    class Conta {

        private string _nome;
        public int NumeroConta { get; set; }
        public double Valor { get; private set; }

        public Conta(string nome, int numeroConta, double valor){
            _nome = nome;
            NumeroConta = numeroConta;
            Valor = valor;
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



    }
}
