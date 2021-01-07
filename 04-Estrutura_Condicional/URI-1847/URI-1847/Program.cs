using System;

namespace URI_1847 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1847
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1847
             */

            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int C = int.Parse(s[2]);

            //Se a temperatura desceu do 1º para o 2º dia, 
            //mas subiu ou permaneceu constante do 2º para o 3º, 
            //as pessoas ficam felizes :).
            if (A > B && (B < C || B == C)) {
                Console.WriteLine(":)");
            }
            //Se a temperatura subiu do 1º para o 2º dia, 
            //mas desceu ou permaneceu constante do 2º para o 3º, 
            //as pessoas ficam tristes
            else if (A < B && (B > C || B == C)) {
                Console.WriteLine(":(");
            }
            //Se a temperatura subiu do 1º para o 2º dia e do 2º para o 3º, 
            //mas subiu do 2º para o 3º menos do que subira do 1º para o 2º, 
            //as pessoas ficam tristes
            else if (A < B && B < C && (C - B) < (B - A)) {
                Console.WriteLine(":(");
            }
            //Se a temperatura subiu do 1º para o 2º dia e do 2º para o 3º, 
            //mas subiu do 2º para o 3º no mínimo o tanto que subira do 1º para o 2º, 
            //as pessoas ficam felizes
            else if (A < B && B < C && (C - B) >= (B - A)) {
                Console.WriteLine(":)");
            }
            //Se a temperatura desceu do 1º para o 2º dia e do 2º para o 3º, 
            //mas desceu do 2º para o 3º menos do que descera do 1º para o 2º, 
            //as pessoas ficam felizes
            else if (A > B && B > C && (B - C) < (A - B)) {
                Console.WriteLine(":)");
            }
            //Se a temperatura desceu do 1º para o 2º dia e do 2º para o 3º, 
            //mas desceu do 2º para o 3º no mínimo o tanto que descera do 1º para o 2º, 
            //as pessoas ficam tristes
            else if (A > B && B > C && (B - C) >= (A - B)) {
                Console.WriteLine(":(");
            }
            //Se a temperatura permaneceu constante do 1º para o 2º dia, as pessoas ficam felizes 
            //se subiu do 2º para o 3º dia ou tristes caso contrário
            else if (A == B && B < C){
                Console.WriteLine(":)");
            }
            else {
                Console.WriteLine(":(");
            }
        }
    }
}
