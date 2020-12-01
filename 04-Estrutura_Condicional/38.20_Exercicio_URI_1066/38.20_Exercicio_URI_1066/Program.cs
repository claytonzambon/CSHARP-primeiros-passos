using System;

namespace _38._20_Exercicio_URI_1066 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1066
             */

            int valor, countImpar = 0, countPar = 0, countPositivo = 0, countNegativo = 0;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                countPar = countPar + 1;
            else
                countImpar = countImpar + 1;

            if (valor > 0)
                countPositivo = countPositivo + 1;
            else if (valor < 0)
                countNegativo = countNegativo + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                countPar = countPar + 1;
            else
                countImpar = countImpar + 1;

            if (valor > 0)
                countPositivo = countPositivo + 1;
            else if (valor < 0)
                countNegativo = countNegativo + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                countPar = countPar + 1;
            else
                countImpar = countImpar + 1;

            if (valor > 0)
                countPositivo = countPositivo + 1;
            else if (valor < 0)
                countNegativo = countNegativo + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                countPar = countPar + 1;
            else
                countImpar = countImpar + 1;

            if (valor > 0)
                countPositivo = countPositivo + 1;
            else if (valor < 0)
                countNegativo = countNegativo + 1;

            valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                countPar = countPar + 1;
            else
                countImpar = countImpar + 1;

            if (valor > 0)
                countPositivo = countPositivo + 1;
            else if (valor < 0)
                countNegativo = countNegativo + 1;

            Console.WriteLine(countPar + " valor(es) par(es)");
            Console.WriteLine(countImpar + " valor(es) impar(es)");
            Console.WriteLine(countPositivo + " valor(es) positivo(s)");
            Console.WriteLine(countNegativo + " valor(es) negativo(s)");
        }
    }
}
