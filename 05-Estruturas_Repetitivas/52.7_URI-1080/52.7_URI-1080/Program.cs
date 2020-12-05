using System;

namespace _52._7_URI_1080 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1080
             */

            int valor, maior = 0, posicaoMaior = 0;

            for (int i = 1; i <= 100; i++) {
                valor = int.Parse(Console.ReadLine());
                if (valor > maior) {
                    maior = valor;
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicaoMaior);
        }
    }
}
