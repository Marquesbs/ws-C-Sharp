using System;
using System.Globalization;

namespace Exercícios_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Entre com o valor do dólar hoje: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            System.Console.WriteLine("Valor a ser pago em Reais: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
