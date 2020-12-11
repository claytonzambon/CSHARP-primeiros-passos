using System;

namespace _61._6_Exercicio_Vetores_06 {
    class Program {
        static void Main(string[] args) {

            //Ler a quantidade de elementos que terá o Vetor
            int N;
            N = int.Parse(Console.ReadLine());

            //Declarar Vetor de String e inteiros com N elementos
            string[] nome = new string[N];
            int[] idade = new int[N];

            //Ler dados do Teclado e popular os vetores
            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
            }

            //Verificar qual a maior idade
            int maisVelho = 0;
            string nomeVelho = " ";
            for (int i = 0; i < N; i++) {
                if (maisVelho < idade[i]) {
                    maisVelho = idade[i];
                    nomeVelho = nome[i];
                }
            }

            //Exibir o nome da Pessoa mais velha
            Console.WriteLine("Pessoa mais velha: " + nomeVelho);
        }
    }
}
