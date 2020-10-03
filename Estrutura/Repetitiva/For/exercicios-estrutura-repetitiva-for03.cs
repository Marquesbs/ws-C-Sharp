using System;
using System.Globalization;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_de_casos = int.Parse(Console.ReadLine());
            double n1, n2, n3, media;
            
            for (int cont = 0; cont <= numero_de_casos; cont++)
            {
                string[] casos = Console.ReadLine().Split(' ');
                n1 = double.Parse(casos[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(casos[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(casos[2], CultureInfo.InvariantCulture);
                media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10;

                System.Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
