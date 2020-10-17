using System;
using System.Globalization;

namespace Exercícios_de_Fixação
{
    public class ConversorDeMoeda
    {
        public static double IOF = 6.0 / 100.0;
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF;
        }
    }
}