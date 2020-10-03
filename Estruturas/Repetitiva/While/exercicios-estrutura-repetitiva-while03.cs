using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Escolha um tipo de combustível: ");
            int selecao = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;
            while (selecao != 4)
            {
                if (selecao == 1)
                {
                    alcool++;
                }
                else if (selecao == 2)
                {
                    gasolina++;
                }
                else if (selecao == 3)
                {
                    diesel++;
                }
                selecao = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("MUITO OBRIGADO!");
            System.Console.WriteLine("Álcool: " + alcool);
            System.Console.WriteLine("Gasolina: " + gasolina);
            System.Console.WriteLine("Diesel: " + diesel);
        }
    }
}
