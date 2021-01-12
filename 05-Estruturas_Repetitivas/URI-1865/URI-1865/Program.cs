using System;

namespace URI_1865 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1865
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1865
             */

            //Declarar variável e ler valor digitado
            int C = int.Parse(Console.ReadLine());

            for (int i = 0; i < C; i++) {

                string[] s = Console.ReadLine().Split(' ');

                if (s[0].Equals("Thor")) {
                    Console.WriteLine("Y");
                }
                else {
                    Console.WriteLine("N");
                }
            }
        }
    }
}
