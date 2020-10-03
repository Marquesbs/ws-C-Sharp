using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int Eixo_X = int.Parse(valores[0]);
            int Eixo_Y = int.Parse(valores[1]);

            while (Eixo_X != 0 && Eixo_Y != 0)
            {
                if (Eixo_X > 0 && Eixo_Y > 0)
                {
                    System.Console.WriteLine("primeiro");
                }
                else if (Eixo_X > 0 && Eixo_Y < 0)
                {
                    System.Console.WriteLine("quarto");
                }
                else if (Eixo_X < 0 && Eixo_Y > 0)
                {
                    System.Console.WriteLine("segundo");
                }
                else
                {
                    System.Console.WriteLine("terceiro");
                }
                valores = Console.ReadLine().Split(' ');
                Eixo_X = int.Parse(valores[0]);
                Eixo_Y = int.Parse(valores[1]);
            }
        }
    }
}
