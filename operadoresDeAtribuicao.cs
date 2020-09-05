using System;

namespace OperadoresDeAtribuicao
{
    class operadores
    {
        static void Main(string[] args)
        {
            int a = 10; //a variável RECEBE o valor 10
            System.Console.WriteLine(a);
            a += 2; //o valor de a RECEBE a e soma 2 
            System.Console.WriteLine(a);
            a -= 2; //o valor de a RECEBE a e subtrai 2
            System.Console.WriteLine(a);
            a *= 3; // o valor de a RECEBE a e multiplica por 3
            System.Console.WriteLine(a);
            a /= 2; // o valor de a RECEBE a e divide por 2
            System.Console.WriteLine(a);
            a %= 3; // o valor de a RECEBE a e o retorna o resto da divisão por 3
            System.Console.WriteLine(a);
            
            string b = "ABC";
            System.Console.WriteLine(b);

            b += "DEF";
            System.Console.WriteLine(b);
            
            a++;
            System.Console.WriteLine(a);
            a--;
            System.Console.WriteLine(a);
            

        }
    }
}
