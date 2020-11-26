using System;

namespace _38._11_Exercicio_URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1047
             */

            int horaInicial, minutoInicial, horaFinal, minutoFinal, duracaoHora, duracaoMinutos, duracaoTotal;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            int momentoInicial = horaInicial * 60 + minutoInicial;
            int momentoFinal = horaFinal * 60 + minutoFinal;

            if (momentoInicial < momentoFinal)
                duracaoTotal = momentoFinal - momentoInicial;
            else
                duracaoTotal = (24 * 60 - momentoInicial) + momentoFinal;

            duracaoHora = duracaoTotal / 60;
            duracaoMinutos = duracaoTotal % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}
