using System;

namespace conversao
{
    class ImplicitaCasting
    {
        static void Main(string[] args)
        {
            //Implícita
            float a = 4.5f;

            double b = a;
            System.Console.WriteLine(b);

            //Casting
            double c = 5.1;

            int d = (int)c; //valores depois da vírgula será desprezado por se tornar uma variável Int.
            System.Console.WriteLine(d);

            int x = 5;
            int y = 2;

            double resultado = (double)x / y; //convertendo x para double para que não seja descartado as casas decimais.
            System.Console.WriteLine(resultado);
        }
    }
}
