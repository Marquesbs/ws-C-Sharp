using System;
using System.Globalization;

namespace exercicio04
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public double AumentarSalario(double porcentagem)
        {
            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            porcentagem = double.Parse(Console.ReadLine().ToString("F1", CultureInfo.InvariantCulture));
            double SalarioLiquido = (SalarioBruto * porcentagem) - Imposto;
        }

        public override string ToString()
        {
            return "\nDados Atualizados: " + Nome + ", $" + SalarioLiquido.ToString();
        }
    }
}