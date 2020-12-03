using System;

namespace _46._1_Estrutura_repetitiva_para {
    class Program {
        static void Main(string[] args) {

            int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i = 0; i < N; i++) {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);
        }
    }
}
