using System;

namespace _62._8._URI_1179 {
    class Program {
        static void Main(string[] args) {
            /* Exercício URI-1179
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1179
             */

            int[] par = new int[5];
            int[] impar = new int[5];
            int countPar = 0, countImpar = 0;

            for (int i = 0; i < 15; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0) {
                    par[countPar] = valor;
                    countPar++;
                }
                else {
                    impar[countImpar] = valor;
                    countImpar++;
                }

                if (countPar == 5) {
                    for (int j = 0; j < 5; j++) {
                        Console.WriteLine("par[" + j + "] = " + par[j]);
                    }
                    countPar = 0;
                }
                if (countImpar == 5) {
                    for (int j = 0; j < 5; j++) {
                        Console.WriteLine("impar[" + j + "] = " + impar[j]);
                    }
                    countImpar = 0;
                }
            }

            for (int i = 0; i < countImpar; i++) {
                if (impar[i] != ' ') {
                    Console.WriteLine("impar[" + i + "] = " + impar[i]);
                }
            }

            for (int i = 0; i < countPar; i++) {
                if (par[i] != ' ') {
                    Console.WriteLine("par[" + i + "] = " + par[i]);
                }
            }
        }
    }
}
