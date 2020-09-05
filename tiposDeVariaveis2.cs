using System;

namespace projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; //tipo verdadeiro / falso
            char genero = 'F';  //caractere aspas simples
            char letra = '\u0041'; //código Unicode da letra A maiúsculo
            string nome = "Maria Green"; //texto ou frase, aspas duplas IMUTÁVEL.
            object obj1 = "Alex"; //object é um tipo genérico
            object obj2 = 4.5f;

            byte n1 = 126; // numero inteiro com sinal (-128 até 127)
            int n2 = 4324; // numero inteiro com sinal
            long n3 = 627692384570913L; // numero inteiro longo com sinal
            float n4 = 4.5f; // numero "quebrado" precisa do f no final
            double n5 = 4.5; // 

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            System.Console.WriteLine(letra);
            System.Console.WriteLine(n4);
            System.Console.WriteLine(n5);
            System.Console.WriteLine(nome);
            System.Console.WriteLine(obj1);
            System.Console.WriteLine(obj2);
        }
    }
}
