using System;
using System.Globalization;

namespace exercicios_estrutura_sequencial
{
    class Exercicio04
    {
        static void Main(string[] args)
        {
            int funcionario, hora_trabalhada;
            double recebe_hora, salario;
            
            funcionario = int.Parse(Console.ReadLine());
            hora_trabalhada = int.Parse(Console.ReadLine());
            recebe_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            salario = hora_trabalhada * recebe_hora;
            
            System.Console.WriteLine("NUMBER = " + funcionario);
            System.Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));          
        }
    }
}
