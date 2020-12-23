using System;

namespace _62._4._URI_1175 {
    class Program {
        static void Main(string[] args) {
            /* URI-1175
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1175
             */

            int[] N = new int[20];
            int[] N2 = new int[20];

            for (int i = 0; i < 20; i++) {
                N[i] = int.Parse(Console.ReadLine());
            }

            int count = 19;
            for (int i = 0; i < 20; i++) {
                N2[count] = N[i];
                count--;
            }

            for (int i = 0; i < 20; i++) {
                Console.WriteLine("N[" + i + "] = " + N2[i]);
            }
        }
    }
}
