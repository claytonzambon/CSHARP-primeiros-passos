using System;
using System.Globalization;

namespace _61._8_Exercicio_Vetores_08 {
    class Program {
        static void Main(string[] args) {

            //Ler a quantidade de elementos que terá o Vetor
            int N;
            N = int.Parse(Console.ReadLine());

            //Declara vetor altura e sexo do tamanho N
            double[] altura = new double[N];
            char[] sexo = new char[N]; //Sendo M ou F

            //Ler dados do teclado e popular os vetores
            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vet[1]);
            }

            //Verificar qual a menor altura informada
            double menorAltura = 3.0;
            for (int i = 0; i < N; i++) {
                if (menorAltura > altura[i]) {
                    menorAltura = altura[i];
                }
            }
            //Exibindo a menor altura
            Console.WriteLine("Menor altura: " +
                menorAltura.ToString("F2", CultureInfo.InvariantCulture));

            //Verificar qual a maior altura informada
            double maiorAltura = 0.0;
            for (int i = 0; i < N; i++) {
                if (maiorAltura < altura[i]) {
                    maiorAltura = altura[i];
                }
            }
            //Exibindo a maior altura
            Console.WriteLine("Maior altura: " + 
                maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            //Calculando e Exibindo a media das alturas das mulheres e
            //verificando a quantidade de homens
            double alturaMulheres = 0.0;
            int countMulheres = 0;
            int countHomens = 0;
            for (int i = 0; i < N; i++) {
                if (sexo[i] == 'F') {
                    alturaMulheres += altura[i];
                    countMulheres++;
                }
                else {
                    countHomens++;
                }
            }
            double media = alturaMulheres / countMulheres;
            Console.WriteLine("Media das alturas das mulheres = " 
                + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Numero de homens = " + countHomens);
        }
    }
}
