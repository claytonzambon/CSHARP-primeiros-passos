﻿using System;

namespace _38._16_Exercicio_URI_1052 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI Onlline Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1052
             */

            int valor = int.Parse(Console.ReadLine());
            string mes;

            switch (valor) {
                case 1:
                    mes = "January";
                    break;
                case 2:
                    mes = "February";
                    break;
                case 3:
                    mes = "March";
                    break;
                case 4:
                    mes = "April";
                    break;
                case 5:
                    mes = "May";
                    break;
                case 6:
                    mes = "June";
                    break;
                case 7:
                    mes = "July";
                    break;
                case 8:
                    mes = "August";
                    break;
                case 9:
                    mes = "September";
                    break;
                case 10:
                    mes = "October";
                    break;
                case 11:
                    mes = "November";
                    break;
                default:
                    mes = "December";
                    break;
            }

            Console.WriteLine(mes);
        }
    }
}
