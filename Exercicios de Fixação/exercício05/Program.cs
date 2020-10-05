using System;
using System.Globalization;

namespace exercício05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();

            Console.Write("Nome do Aluno: ");
            al.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno:");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("NOTA FINAL = " + al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (al.Aprovado()) 
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
