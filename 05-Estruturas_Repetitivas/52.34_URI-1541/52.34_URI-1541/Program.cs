using System;

namespace _52._34_URI_1541 {
    class Program {
        static void Main(string[] args) {
            /* URI-1541
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1541
             */

            while(true) {
                string[] s = Console.ReadLine().Split(' ');
                if (int.Parse(s[0]) == 0 || int.Parse(s[1]) == 0 || int.Parse(s[2]) == 0) {
                    break;
                }
                else {
                    int A = int.Parse(s[0]);
                    int B = int.Parse(s[1]);
                    int C = int.Parse(s[2]);

                    double resultado = Math.Truncate(Math.Sqrt((A * B * 100) / C));

                    Console.WriteLine(resultado);
                }
            }
        }
    }
}
