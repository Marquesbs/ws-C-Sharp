using System;
using System.Globalization;

namespace exercício04
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        
        public double SalarioLiquido()
        {
            return "Funcionário: " + Nome + "$" + (SalarioBruto - Imposto);
        }
        public void AumentarSalario(double Porcentagem)
        {
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            Porcentagem = double.Parse(Console.ReadLine().ToString("F2", CultureInfo.InvariantCulture));
            Porcentagem = (SalarioBruto / porcentagem) * 100;
            return "Dados Atualizados: " + Nome + "$" + ((SalarioBruto + Porcentagem)-Imposto);
        }

    }
}