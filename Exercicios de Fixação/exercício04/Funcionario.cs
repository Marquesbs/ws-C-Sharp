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
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto / porcentagem);
        }
        public override string ToString()
        {
            return Nome
            + ", R$"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}