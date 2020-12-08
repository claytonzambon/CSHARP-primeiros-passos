using System;

namespace _52._18_URI_1142 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1142
             */

            int N = int.Parse(Console.ReadLine());

            int primeiro = 1;
            for (int i = 1; i <= N; i++) {

                int segundo = primeiro + 1;
                int terceiro = primeiro + 2;
                Console.WriteLine(primeiro + " " + segundo + " " + terceiro + " PUM");

                primeiro += 4;
            }
        }
    }
}
