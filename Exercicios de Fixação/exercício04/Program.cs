using System;
using System.Globalization;

namespace exercício04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario n = new Funcionario();
            System.Console.Write("Nome: ");
            n.Nome = Console.ReadLine();
            System.Console.Write("Salário Bruto: ");
            n.SalarioBruto = double.Parse(Console.ReadLine().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Imposto: ");
            n.Imposto = double.Parse(Console.ReadLine().ToString("F2", CultureInfo.InvariantCulture));

            SalarioLiquido();

            AumentarSalario();
        }
    }
}
