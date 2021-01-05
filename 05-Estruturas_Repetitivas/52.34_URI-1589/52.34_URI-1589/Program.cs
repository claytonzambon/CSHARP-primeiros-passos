using System;

namespace _52._34_URI_1589 {
    class Program {
        static void Main(string[] args) {
            /* URI-1589
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1589
             */
            
            //Declarar variável e ler numero digitado
            int T = int.Parse(Console.ReadLine());

            //Ler os Raios R1 e R2 e exibir resultado
            for (int i = 0; i < T; i++) {
                string[] s = Console.ReadLine().Split(' ');
                int R1 = int.Parse(s[0]);
                int R2 = int.Parse(s[1]);
                Console.WriteLine(R1 + R2);
            }
        }
    }
}
