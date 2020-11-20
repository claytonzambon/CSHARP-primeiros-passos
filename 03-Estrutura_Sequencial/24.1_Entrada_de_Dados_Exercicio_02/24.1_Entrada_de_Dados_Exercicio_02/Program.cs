using System;
using System.Globalization;

namespace _24._1_Entrada_de_Dados_Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double B, A, area, perimetro, diagonal;

            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (B * A);
            perimetro = (2 * B) + (2 * A);
            diagonal = Math.Sqrt(Math.Pow(B, 2.0) + Math.Pow(A, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
