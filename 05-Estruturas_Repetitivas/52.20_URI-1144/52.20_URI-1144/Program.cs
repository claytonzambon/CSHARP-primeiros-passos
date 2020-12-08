using System;

namespace _52._20_URI_1144 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1144
             */

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {

                int prodSegundo = i * i;
                int prodTerceiro = i * i * i;

                Console.WriteLine(i + " " + prodSegundo + " " + prodTerceiro);
                Console.WriteLine(i + " " + (prodSegundo + 1) + " " + (prodTerceiro + 1));
            }
        }
    }
}
