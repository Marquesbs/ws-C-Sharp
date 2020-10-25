using System.Globalization;

namespace Exercicio_de_fixacao06
{
    public class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }
        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo = (Saldo - saque) - 5.00;
        }

        public override string ToString()
        {
            return "\nDados Atualizados:\n Conta: "
            + Conta
            + ", Titular: "
            + Titular
            + " Saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}