using System;
using System.Globalization;

namespace Solução01
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());
            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
