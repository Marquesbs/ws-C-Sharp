using System;
using System.Globalization;

namespace exercicios_estrutura_sequencial
{
    class exercicio02
    {
        static void Main(string[] args)
        {
            double raio, area, pi;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * (Math.Pow(raio,2));

            System.Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
