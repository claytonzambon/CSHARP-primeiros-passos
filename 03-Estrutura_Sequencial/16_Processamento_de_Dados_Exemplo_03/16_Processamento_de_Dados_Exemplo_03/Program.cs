using System;

namespace _16_Processamento_de_Dados_Exemplo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculando a área do Trapézio
            //Dados: b = 6, h = 5, B = 8
            //       b = 6
            //      ------------
            //      |           |
            //      |            |
            //  h=5 |             |
            //      |              |
            //      ----------------
            //          B = 8
            //Fórmula: area = ((b + B)/2) * h

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
