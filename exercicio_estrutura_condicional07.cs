using System.Globalization;
using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double Eixo_Y, Eixo_X;
            string[] coordenadas = Console.ReadLine().Split(' ');
            Eixo_X = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            Eixo_Y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (Eixo_X == 0.0 && Eixo_Y == 0.0)
            {
                System.Console.WriteLine("Origem");
            }
            else if (Eixo_X > 0.0 && Eixo_Y > 0.0)
            {
                System.Console.WriteLine("Q1");
            }
            else if (Eixo_X > 0.0 && Eixo_Y < 0.0)
            {
                System.Console.WriteLine("Q4");
            }
            else if (Eixo_X < 0.0 && Eixo_Y > 0.0)
            {
                System.Console.WriteLine("Q2");
            }
            else
            {
                System.Console.WriteLine("Q3");
            }
        }
    }
}
