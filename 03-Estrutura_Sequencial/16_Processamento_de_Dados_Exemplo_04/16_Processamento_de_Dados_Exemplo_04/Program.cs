using System;

namespace _16_Processamento_de_Dados_Exemplo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting
            //É a conversão explícita de um tipo para outro
            //É necéssário quando o compilador não é capax de adivinhar que o resultado
            //de uma expressão deve ser de outro tipo
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double)a/b;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
