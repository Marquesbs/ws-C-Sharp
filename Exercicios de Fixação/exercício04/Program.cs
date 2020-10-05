using System;
using System.Globalization;

namespace exercício04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            System.Console.Write("\nNome: ");
            func.Nome = Console.ReadLine();
            System.Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            System.Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            System.Console.WriteLine("Funcionário: " + func);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            func.AumentarSalario(porcentagem);

            System.Console.WriteLine("\nDados Atualizados: " + func);
        }
    }
}
