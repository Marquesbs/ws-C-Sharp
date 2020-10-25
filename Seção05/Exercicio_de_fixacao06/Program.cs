using System;
using System.Globalization;

namespace Exercicio_de_fixacao06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaBancaria c;

            double auxiliar = 0.0;
            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLower());
            if (resposta == 's')
            {
                System.Console.Write("Entre o valor de depósito inicial: ");
                auxiliar = double.Parse(Console.ReadLine());
                c = new ContaBancaria(conta, titular, auxiliar);
                            System.Console.WriteLine("\nDados da Conta:\n Conta: " + conta 
                            + ", Titular: "+ titular
                            + " Saldo: $" + auxiliar.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                c = new ContaBancaria(conta, titular);
                System.Console.WriteLine("\nDados da Conta:\n Conta: " + conta 
                + ", Titular: "+ titular
                + " Saldo: $" + auxiliar.ToString("F2", CultureInfo.InvariantCulture));
            }
            System.Console.Write("Insira o valor do depósito: ");
            auxiliar = double.Parse(Console.ReadLine());
            c.Deposito(auxiliar);

            System.Console.WriteLine(c);
            auxiliar = 0.0;

            System.Console.WriteLine("Insira o valor do Saque: ");
            auxiliar = double.Parse(Console.ReadLine());
            c.Saque(auxiliar);
            System.Console.WriteLine(c);
        }
    }
}
