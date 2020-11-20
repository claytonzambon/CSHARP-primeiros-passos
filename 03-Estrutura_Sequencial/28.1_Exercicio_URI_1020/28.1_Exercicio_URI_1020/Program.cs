using System;

namespace _28._1_Exercicio_URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1020
             */

            int idade, ano, mes, dia, resto;

            idade = int.Parse(Console.ReadLine());

            ano = idade / 365;
            resto = idade % 365;
            Console.WriteLine(ano + " ano(s)");

            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
