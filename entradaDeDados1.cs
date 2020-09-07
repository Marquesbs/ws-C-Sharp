using System;

namespace entradaDeDados
{
    class Dados
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine(); //Console.ReadLine armazerna na variável frase o que foi digitado pelo usuário no console.
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] s = Console.ReadLine().Split(' ');
// string[] cria um vetor, .Split(' ') recorta a string e armazena no vetor sempre que ouver um espaço em branco.
// o que estiver dentro dos parenteses é o que é determinado para o corte.
            string p1 = s[0];
            string p2 = s[1];
            string p3 = s[2];

            System.Console.WriteLine(frase);
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
            System.Console.WriteLine(s);
            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);
            System.Console.WriteLine(p3);
        }
    }
}
