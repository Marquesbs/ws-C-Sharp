using System;
using System.Globalization;

namespace Projeto16
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;
            pessoa1 = new Dados();
            pessoa2 = new Dados();
            
            System.Console.Write("\nEntre com os dados do primeiro funcionário: \nNome:");
            pessoa1.nome = Console.ReadLine();
            System.Console.Write("Salario: ");
            pessoa1.salario = double.Parse(Console.ReadLine());

            System.Console.Write("\nEntre com os dados do primeiro funcionário: \nNome:");
            pessoa2.nome = Console.ReadLine();
            System.Console.Write("Salario: ");
            pessoa2.salario = double.Parse(Console.ReadLine());

            double media = (pessoa1.salario + pessoa2.salario) / 2;
            System.Console.WriteLine("Salário Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
