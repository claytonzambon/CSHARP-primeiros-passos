using System;

namespace URI_1864 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1864
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1864
             */

            int N = int.Parse(Console.ReadLine());

            string frase = "LIFE IS NOT A PROBLEM TO BE SOLVED";

            for (int i = 0; i < N; i++) {
                Console.Write(frase[i]);
            }
            Console.WriteLine();
        }
    }
}
