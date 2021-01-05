using System;

namespace _52._36_URI_1759 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1759
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1759
             */
            
            //Declarar variável e ler numero digitado
            int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++) {
                if (i < (N-1)) {
                    Console.Write("Ho ");
                }
                else{
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}
