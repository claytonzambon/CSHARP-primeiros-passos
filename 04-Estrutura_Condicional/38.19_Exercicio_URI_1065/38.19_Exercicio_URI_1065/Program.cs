using System;

namespace _38._19_Exercicio_URI_1065 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1065
             */

            int valor, count = 0;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                count = count + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                count = count + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                count = count + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                count = count + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                count = count + 1;

            Console.WriteLine(count + " valores pares");
        }
    }
}
