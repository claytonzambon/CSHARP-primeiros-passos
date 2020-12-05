using System;

namespace _50._1_URI_1071 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1071
             */

            int x, y, menor, maior, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y) {
                menor = x;
                maior = y;
            }
            else {
                menor = y;
                maior = x;
            }

            soma = 0;
            for (int i = menor + 1; i < maior; i++) {
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
