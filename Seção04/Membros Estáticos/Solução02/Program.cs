using System;
using System.Globalization;

namespace Solução02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());
            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
