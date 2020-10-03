using System;
using System.Globalization;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double numerador, denominador;
            double result;

            for (int contador = 0; contador < num; contador++)
            {
                numerador = double.Parse(Console.ReadLine());
                denominador = double.Parse(Console.ReadLine());
                if (denominador == 0)
                {
                    System.Console.WriteLine("DIVISÃO IMPOSSÍVEL");
                }
                else
                {
                    result = numerador/ denominador;
                    System.Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
