using System;

namespace operadoresaritmeticos
{
    class Operadores
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2; //prioridade na multiplicação por padrão
            int n2 = (3 + 4) * 2; // parenteses primeiro, depois a multiplicação.
            int n3 = 17 % 3;
            int n4 = 10 / 8; //ele entende que a expressão que quero é um valor inteiro, sendo assim vai desprezar o que estiver depois da vírgula.
            double n5 = (double)10 / 8; //o casting é necessário para indicar que um dos valores é double.
            double n6 = 10.0 / 8; //ao invés de utilizar o castindo, posso colocar 10.0 para indicar que eu quero uma expressão utilizando o double.


            //criando a fórmula de bhaskara.
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;
            double delta_alt = Math.Pow(b,2.0) - 4.0 * a * c; //Math.Pow serve para potenciação.
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Math.Sqrt serve para tirar a raiz quadrada do que estiver entre os parênteses.
            
            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
            System.Console.WriteLine(n4);
            System.Console.WriteLine(n5);
            System.Console.WriteLine(n6);
            System.Console.WriteLine(delta);
            System.Console.WriteLine(x1);
        }
    }
}
