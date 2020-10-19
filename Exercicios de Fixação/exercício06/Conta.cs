using System;
using System.Globalization;

namespace exercício06
{
    public class Conta
    {
        public int Numero { get; private set;} //numero da conta não pode ser alterado.
        public string Nome { get; set;}
        public double Saldo { get; set;}
        public string Resposta { get; set;}
        public double Saque { get; private set;}

        public Conta(int numero, string nome, string resposta, double saldo, double saque) //construtor deve possuir o mesmo nome da classe
        {
            Numero = numero;
            Nome = nome;
            Resposta = resposta;
            Saldo = saldo;
            Saque = saque;
        }

        public void DepositarValor(double deposito)
        {
            System.Console.Write("\nEntre com o valor do depósito: ");
            deposito = double.Parse(Console.ReadLine());
            Saldo += deposito;
        }

        public void SaqueValor(double saque)
        {
            System.Console.WriteLine("\nEntre com o valor do saque: ");
            saque = double.Parse(Console.ReadLine());
            Saldo = Saldo - saque - 5.00;
        }

        public override string ToString()
        {
            return "\nDados da conta atualizados: \n"
            + "Conta: " + Numero
            + ", Titular: " + Nome
            + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
