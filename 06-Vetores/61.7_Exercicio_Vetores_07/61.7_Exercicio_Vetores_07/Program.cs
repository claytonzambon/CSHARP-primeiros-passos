using System;
using System.Globalization;

namespace _61._7_Exercicio_Vetores_07 {
    class Program {
        static void Main(string[] args) {

            //Ler a quantidade de elementos que terão os vetores
            int N;
            N = int.Parse(Console.ReadLine());

            //Declarar vetores de string e int
            string[] nome = new string[N];
            double[] nota01 = new double[N];
            double[] nota02 = new double[N];

            //Ler dados do Teclado e popular os vetores
            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                nota01[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota02[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            //Exibir alunos aprovados com média maior que 6.0
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++) {
                double media = (nota01[i] + nota02[i]) / 2;
                if (media >= 6.0) {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}
