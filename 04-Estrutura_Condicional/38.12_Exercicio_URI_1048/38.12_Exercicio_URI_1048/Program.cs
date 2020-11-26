using System;
using System.Globalization;

namespace _38._12_Exercicio_URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1048
             */

            double salario, novoSalario, reajuste;
            int percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                percentual = 15;
            } 
            else if (salario >= 400.01 && salario <= 800.00){
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = 12;
            }
            else if (salario >= 800.01 && salario <= 1200.00) {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = 10;
            } else if (salario >= 1200.01 && salario <= 2000.00){
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = 7;
            }
            else {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = 4;
            }
            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
