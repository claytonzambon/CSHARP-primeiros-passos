using System;

namespace URI_1828 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1828
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1828
             */

            //Declarar variável e ler valor digitado
            int T = int.Parse(Console.ReadLine());
            int count = 1;

            while (count <= T) {
                string[] s = Console.ReadLine().Split(' ');
                string Sheldon = s[0];
                string Raj = s[1];

                if (Sheldon.Equals(Raj)) {
                    Console.WriteLine("Caso #{0}: De novo!", count);
                }
                //01. a tesoura corta o papel;
                else if (Sheldon.Equals("tesoura") && Raj.Equals("papel")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //02. o papel embrulha a pedra;
                else if (Sheldon.Equals("papel") && Raj.Equals("pedra")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //03. a pedra esmaga o lagarto;
                else if (Sheldon.Equals("pedra") && Raj.Equals("lagarto")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //04. o lagarto envenena Spock;
                else if (Sheldon.Equals("lagarto") && Raj.Equals("Spock")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //05. Spock destrói a tesoura;
                else if (Sheldon.Equals("Spock") && Raj.Equals("tesoura")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //06. a tesoura decapita o lagarto;
                else if (Sheldon.Equals("tesoura") && Raj.Equals("lagarto")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //07. o lagarto come o papel;
                else if (Sheldon.Equals("lagarto") && Raj.Equals("papel")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //08. o papel contesta Spock;
                else if (Sheldon.Equals("papel") && Raj.Equals("Spock")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //09. Spock vaporiza a pedra;
                else if (Sheldon.Equals("Spock") && Raj.Equals("pedra")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //10. a pedra quebra a tesoura.
                else if (Sheldon.Equals("pedra") && Raj.Equals("tesoura")) {
                    Console.WriteLine("Caso #{0}: Bazinga!", count);
                }
                //Caso Raj Vença
                else {
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", count);
                }
                count++; 
            }
        }
    }
}
