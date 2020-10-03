using System.Globalization;
using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            double Renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Imposto;

            if (Renda <= 2000.0)
            {
                Imposto = 0.0;
            }
            else if (Renda <= 3000.0)
            {
                Imposto = (Renda - 2000.00) * 0.08;
            }
            else if (Renda <= 4500.00)
            {
                Imposto = (Renda - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                Imposto = ((Renda - 4500.0) * 0.28) + (1500.0 * 0.18) + (1000.0 * 0.08);
            }
            if (Imposto == 0.0)
            {
                System.Console.WriteLine("Isento");
            }
            else
            {
                System.Console.WriteLine("R$ " + Imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
