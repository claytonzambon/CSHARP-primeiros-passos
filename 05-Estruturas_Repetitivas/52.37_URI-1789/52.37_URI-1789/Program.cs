using System;

namespace _52._37_URI_1789 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1789
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1789
             */

            while (true) {
                //Condição para satisfazer o EOF em C#
                if (!int.TryParse(Console.ReadLine(), out int L)) {
                    break;
                }

                string[] velocidade = Console.ReadLine().Split(' ');

                int auxVelocidade = int.Parse(velocidade[0]);
                for (int i = 0; i < L; i++) {
                    if (auxVelocidade < int.Parse(velocidade[i])) {
                        auxVelocidade = int.Parse(velocidade[i]);
                    }
                }

                if (auxVelocidade < 10) {
                    Console.WriteLine("1");
                }
                else if (auxVelocidade >= 10 && auxVelocidade < 20) {
                    Console.WriteLine("2");
                }
                else {
                    Console.WriteLine("3");
                }
            }
        }
    }
}
