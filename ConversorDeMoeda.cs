using System;
using System.Globalization;

namespace ExercicioConversao
{
    class ConversorDeMoeda
    {
        public static double IoF = 6.0;
       
        public static double Conversao(double valor, double cotacao)
        {
            double total = valor * cotacao;
            return total + total * IoF / 100.0;
        }
    }
}
