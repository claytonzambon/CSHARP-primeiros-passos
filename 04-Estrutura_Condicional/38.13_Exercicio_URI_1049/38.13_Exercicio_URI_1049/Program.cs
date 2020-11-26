using System;

namespace _38._13_Exercicio_URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1049
             */

            string animal = Console.ReadLine();

            if (animal == "vertebrado")
            {
                animal = Console.ReadLine();
                if (animal == "ave")
                {
                    animal = Console.ReadLine();
                    if (animal == "carnivoro")
                        Console.WriteLine("aguia");
                    else
                        Console.WriteLine("pomba");
                }
                else
                {
                    animal = Console.ReadLine();
                    if (animal == "onivoro")
                        Console.WriteLine("homem");
                    else
                        Console.WriteLine("vaca");
                }
            }
            else
            {
                animal = Console.ReadLine();
                if (animal == "inseto")
                {
                    animal = Console.ReadLine();
                    if (animal == "hematofago")
                        Console.WriteLine("pulga");
                    else
                        Console.WriteLine("lagarta");
                }
                else
                {
                    animal = Console.ReadLine();
                    if (animal == "hematofago")
                        Console.WriteLine("sanguessuga");
                    else
                        Console.WriteLine("minhoca");
                }
            }
        }
    }
}
