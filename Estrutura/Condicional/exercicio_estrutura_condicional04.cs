using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);            
            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaInicial - horaFinal;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            System.Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }
    }
}
