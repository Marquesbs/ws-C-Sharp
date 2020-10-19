using System;
using System.Globalization;

namespace exercício06
{
    class Program
    {
        static void Main(string[] args)
        {   
            double deposito = 0.0;
            double saque = 0.0;        
            System.Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com o Titular da conta: ");
            string nome = Console.ReadLine();
            System.Console.Write("Haverá depósito inicial (S/N)? ");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                System.Console.Write("\nEntre com o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("\nDados da conta: \n Conta: {0}, Titular: {1}, Saldo: ${2}", numero, nome, deposito.ToString("F2", CultureInfo.InvariantCulture));

            Conta c = new Conta(numero, nome, resposta, deposito, saque);

            c.DepositarValor(deposito);
            System.Console.WriteLine(c);

            c.SaqueValor(saque);
            System.Console.WriteLine(c);
        }
    }
}
