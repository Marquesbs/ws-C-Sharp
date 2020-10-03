using System;
using System.Globalization;

namespace exercício03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo n = new Retangulo();
            Console.WriteLine("Entre a Largura e a Altura do retângulo: ");
            n.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine(n);
        }
    }
}
