using System;

namespace URI_1866 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1866
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1866
             */

            int C = int.Parse(Console.ReadLine());

            for (int i = 0; i < C; i++) {
                int S = int.Parse(Console.ReadLine());
                int soma = 1;
                for (int j = 0; j <= S; j++) {
                    if (soma == 1) {
                        soma -= 1;
                    }
                    else {
                        soma += 1;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
