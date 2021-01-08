using System;

namespace URI_1858 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1858
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1858
             */
            
            //Declarar e Ler valor digitado (numero de Algozes)
            int N = int.Parse(Console.ReadLine());

            int[] T = new int[N];
            

            //Ler valores digitados (Número de vezes que o Algoz irá atingir Theon)
            string[] s = Console.ReadLine().Split(' ');

            //Popular vetor com os valors Digitados
            for (int i = 0; i < N; i++) {
                T[i] = int.Parse(s[i]);
            }

            int menor = T[0];
            int posicao = 0;

            //Verificar qual a posição com o menor número
            //de vezes que irá atingir Theon
            for (int i = 0; i < N; i++) {
                if (menor > T[i]) {
                    menor = T[i];
                    posicao = i;
                }
            }

            //Exibir a posição do Algoz
            Console.WriteLine(posicao + 1);

        }
    }
}
