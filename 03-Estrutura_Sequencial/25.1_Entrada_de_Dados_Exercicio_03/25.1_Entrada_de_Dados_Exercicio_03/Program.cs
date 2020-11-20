using System;
using System.Globalization;

namespace _25._1_Entrada_de_Dados_Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double idadeMedia;

            string[] vetor1 = Console.ReadLine().Split(' ');
            nome1 = vetor1[0];
            idade1 = int.Parse(vetor1[1]);

            string[] vetor2 = Console.ReadLine().Split(' ');
            nome2 = vetor2[0];
            idade2 = int.Parse(vetor2[1]);

            idadeMedia = (double)(idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + 
                nome1 + 
                " e " + 
                nome2 + 
                " é de " + 
                idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + 
                " anos");
        }
    }
}
