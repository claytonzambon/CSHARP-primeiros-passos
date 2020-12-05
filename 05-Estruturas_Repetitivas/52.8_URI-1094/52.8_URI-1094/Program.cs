using System;
using System.Globalization;

namespace _52._8_URI_1094 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1094
             */

            int N, quantia;
            int countCoelhos = 0, countRatos = 0, countSapos = 0, total = 0;
            char tipo;
            double percentualCoelhos, percentualRatos, percentualSapos;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);

                if (tipo == 'C') {
                    countCoelhos += quantia;
                }
                else if (tipo == 'R') {
                    countRatos += quantia;
                }
                else {
                    countSapos += quantia;
                }
                
            }

            total = countCoelhos + countRatos + countSapos;
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + countCoelhos);
            Console.WriteLine("Total de ratos: " + countRatos);
            Console.WriteLine("Total de sapos: " + countSapos);

            percentualCoelhos = (double)countCoelhos / total * 100;
            percentualRatos = (double)countRatos / total * 100;
            percentualSapos = (double)countSapos / total * 100;
            Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
