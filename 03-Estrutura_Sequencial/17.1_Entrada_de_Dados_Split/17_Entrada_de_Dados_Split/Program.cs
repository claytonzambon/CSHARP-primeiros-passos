using System;

namespace _17_Entrada_de_Dados_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.ReadLine();
        }
    }
}
