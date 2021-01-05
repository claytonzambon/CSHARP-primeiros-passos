using System;

namespace _52._35_URI_1564 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1564
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1564
             */

            while (true) {

                //Condição para satisfazer o EOF em C#
                if (!int.TryParse(Console.ReadLine(), out int N)) {
                    break;
                }

                if (N > 0) {
                    Console.WriteLine("vai ter duas!");
                }
                else {
                    Console.WriteLine("vai ter copa!");
                }
            }
        }
    }
}
