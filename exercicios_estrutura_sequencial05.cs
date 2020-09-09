Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
using System;
using System.Globalization;

namespace exercicios_estrutura_sequencial
{
    class Exercicio04
    {
        static void Main(string[] args)
        {
            int peca01, num_peca01, peca02, num_peca02;
            double valor01, valor02, total;
            
            string[] vet = (Console.ReadLine().Split(' '));
            peca01 = int.Parse(vet[0]);
            num_peca01 = int.Parse(vet[1]);
            valor01 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            string[] vet2 = (Console.ReadLine().Split(' '));
            peca02 = int.Parse(vet[0]);
            num_peca02 = int.Parse(vet[1]);
            valor02 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            total = num_peca01 * valor01 + num_peca02 * valor02;
            
            System.Console.WriteLine("VALOR A PAGAR = R$ " + total.ToString("F2", CultureInfo,InvariantCulture));
            
        }
    }
}
