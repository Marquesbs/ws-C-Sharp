﻿using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1;i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
