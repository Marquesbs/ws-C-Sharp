using System.ComponentModel;
using System;
using System.Globalization; //para utilizar o Culture.Info

namespace entradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); //int.Parse() converte em int a string digitada pelo usuário.
            char ch = char.Parse(Console.ReadLine()); //char.Parse() converte em char a string digitada
 //           double n2 = double.Parse(Console.ReadLine()); //separador precisa ser a vírgula se o computador estiver em português
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //separador por ponto

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            System.Console.WriteLine("\n Você digitou: \n");// \n pula uma linha
            System.Console.WriteLine(n1);
            System.Console.WriteLine(ch);
            System.Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(nome);
            System.Console.WriteLine(sexo);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
