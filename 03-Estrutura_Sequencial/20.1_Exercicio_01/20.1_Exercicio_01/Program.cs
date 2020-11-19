﻿using System;
using System.Globalization;

namespace _20._1_Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Estrutura Sequencial - Exercício 01
            *  Fazer um programa para ler as medidas da largura e comprimento de um 
            *  terreno retangular com uma casa decimal, bem como o valor do metro quadrado
            *  do terreno com duas casas decimais. Em seguida, o programa deve mostrar
            *  o valor da área do terreno, bem como o valor do preço do terreno,
            *  ambos com duas casas decimais, conforme exemplo

            * - Exemplo:
            * | Entrada:  | Saída:			    |
            * |-----------|---------------------|
            * | 10.0      | AREA = 300.00		|
            * | 30.0	  | PRECO = 60000.00    |
            * | 200.00	  |					    |
            */

            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (largura * comprimento);
            preco = (precoMetroQuadrado * area);

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
