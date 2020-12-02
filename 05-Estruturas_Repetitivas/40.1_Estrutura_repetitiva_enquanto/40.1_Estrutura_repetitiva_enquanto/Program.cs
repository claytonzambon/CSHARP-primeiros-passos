using System;

namespace _40._1_Estrutura_repetitiva_enquanto {
    class Program {
        static void Main(string[] args) {
            /* Fazer um programa que lê números inteiros até que um zero seja lido. 
             * Ao final mostra a soma dos números lidos
             */

            int x, soma;

            x = int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0) {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
        }
    }
}
