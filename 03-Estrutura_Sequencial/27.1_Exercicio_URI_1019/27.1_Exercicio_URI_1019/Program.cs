using System;

namespace _27._1_Exercicio_URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1019
             */

            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());
            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
