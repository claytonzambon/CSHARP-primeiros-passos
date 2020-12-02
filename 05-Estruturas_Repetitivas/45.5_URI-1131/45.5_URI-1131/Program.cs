using System;

namespace _45._5_URI_1131 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1131
             */

            int inter, gremio;
            int countInter = 0, countGremio = 0, countEmpate = 0, countGrenais = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1) {
                string[] vet = Console.ReadLine().Split(' ');
                inter = int.Parse(vet[0]);
                gremio = int.Parse(vet[1]);

                if (inter > gremio) {
                    countInter++;
                }
                else if (gremio > inter) {
                    countGremio++;
                }
                else {
                    countEmpate++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
                while (novoGrenal != 1 && novoGrenal != 2) {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    novoGrenal = int.Parse(Console.ReadLine());
                }
                countGrenais++;
            }

            Console.WriteLine(countGrenais + " grenais");
            Console.WriteLine("Inter:" + countInter);
            Console.WriteLine("Gremio:" + countGremio);
            Console.WriteLine("Empates:" + countEmpate);
            if (countInter > countGremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (countGremio > countInter) {
                Console.WriteLine("Gremio venceu mais");
            }
            else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
