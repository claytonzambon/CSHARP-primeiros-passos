using System;

namespace URI_1848 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1848
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1848
             */

            int count = 0;
            int soma = 0;
            while (count < 3) {
                string s = Console.ReadLine();

                if (s == "---") {
                    soma += 0;
                }
                else if (s == "--*") {
                    soma += 1;
                }
                else if (s == "-*-") {
                    soma += 2;
                }
                else if (s == "-**") {
                    soma += 3;
                }
                else if (s == "*--") {
                    soma += 4;
                }
                else if (s == "*-*") {
                    soma += 5;
                }
                else if (s == "**-") {
                    soma += 6;
                }
                else if (s == "***"){
                    soma += 7;
                }
                else {
                    Console.WriteLine("{0}", soma);
                    soma = 0;
                    count++;
                }
            }
        }
    }
}
