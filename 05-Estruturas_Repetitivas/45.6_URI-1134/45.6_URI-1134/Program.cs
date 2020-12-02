using System;

namespace _45._6_URI_1134 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1134
             */

            int countAlcool = 0, countGasolina = 0, countDiesel = 0;

            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 4) {
                if (opcao == 1) {
                    countAlcool++;
                }
                else if (opcao == 2) {
                    countGasolina++;
                }
                else if (opcao == 3) {
                    countDiesel++;
                }
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + countAlcool);
            Console.WriteLine("Gasolina: " + countGasolina);
            Console.WriteLine("Diesel: " + countDiesel);
        }
    }
}
