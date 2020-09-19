using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntidade = int.Parse(Console.ReadLine());
            int n = 0, dentro = 0, fora = 0;

            for (int contador = 1;contador <= qntidade; contador++)
            {
                n = int.Parse(Console.ReadLine());
                if (n >= 10 && n <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            System.Console.WriteLine("{0} in", dentro);
            System.Console.WriteLine("{0} out", fora);
        }
    }
}
