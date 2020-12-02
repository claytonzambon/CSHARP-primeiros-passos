using System;
using System.Globalization;

namespace _44._1_Exercicio_resolvido_02 {
    class Program {
        static void Main(string[] args) {

            double idade, soma, media;
            int count;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            count = 0;
            while (idade >= 0) {
                soma = soma + idade;
                count++;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (count == 0) {
                Console.WriteLine("impossivel calcular");
            }
            else {
                media = soma / count;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
