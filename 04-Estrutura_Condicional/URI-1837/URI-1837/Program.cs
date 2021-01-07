using System;

namespace URI_1837 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1837
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1837
             */

            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            int auxB = 0, auxA = 0, q, r;

            if (a < 0) {
                auxB = b;
                if (b < 0) {
                    auxB = b * (-1);
                }

                for (r = 0; r < auxB; r++) {
                    auxA = a - r;
                    if (auxA % b == 0) {
                        break;
                    }
                }
                q = auxA / b;
            }
            else {
                q = a / b;
                r = a % b;
            }

            Console.WriteLine("{0} {1}", q, r);
        }
    }
}
