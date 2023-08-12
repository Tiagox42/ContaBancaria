using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {
        private int _conta;
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int conta, string nome)
        {
            _conta = conta;
            Nome = nome;
        }
        public Conta(int conta, string nome, double saldo) : this(conta, nome)
        {

            Deposito(saldo);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            if (saque > 0.00)
            {
                Saldo = (Saldo - saque) - 5.00;
            }
        }

        public override string ToString()
        {
            return $"Conta: {_conta}, Titular: {Nome}, Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
