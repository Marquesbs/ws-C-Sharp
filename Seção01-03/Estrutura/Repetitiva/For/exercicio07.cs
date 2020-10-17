using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int quad = 0, cub = 0;
            for (int line = 1; line <= n; line++)
            {
                quad = line * line;
                cub = line * line * line;
                System.Console.WriteLine("{0} {1} {2}", line, quad, cub);
            }
        }
    }
}
