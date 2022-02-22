using System;
using System.Linq;

namespace Atv_7
{
    internal class Program
    {

        static int MaiorValor(int[] sequencia)
        {

            int maiorValor = 0;

            for (int i = 0; i < 10; i++)
            {
                if (sequencia[i] > maiorValor)
                {
                    maiorValor = sequencia[i];
                }
            }
            return maiorValor;
        }


        static int MenorValor(int[] sequencia)
        {
            int menorValor = sequencia[0];

            for (int i = 0; i < 10; i++)
            {
                if (sequencia[i] < menorValor)
                {
                    menorValor = sequencia[i];
                }
            }
            return menorValor;
        }


        static double ValorMedio(int[] sequencia)
        {
            double valorMedio = 0;
            for (int i = 0; i < 10; i++)
            {
                Convert.ToDouble(sequencia[i]);
                valorMedio = valorMedio + sequencia[i];
            }
            return valorMedio / 10;
        }


        static string MaioresValores(int[] sequencia)
        {
            int[] maioresValores = new int[3];
            int x = 0;
            for (int j = 0; j < 10; j++)
            {

                for (int i = 0; i < 9; i++)
                {
                    if (sequencia[i] < sequencia[i + 1])
                    {
                        //Troca de posições do vetor (de casa em casa)
                        x = sequencia[i];                  //Coloca posição i do vetor em uma variavel
                        sequencia[i] = sequencia[i + 1];   //Coloca posição i+1 no lugar da posição i 
                        sequencia[i + 1] = x;               //Coloca variavel x na posição i+1 
                    }
                }

            }
            for (int i = 0; i < 3; i++)
            {
                maioresValores[i] = sequencia[i];
            }
            string result = string.Join(" ", maioresValores);
            return result;
        }


        static string ValoresNegativos(int[] sequencia)
        {
            int[] valoresNegativos = new int[10];
            int cont = 0;   //contador para determinar a quantidade de numeros negativos

            for (int i = 0; i < 10; i++)
            {
                if (sequencia[i] < 0)
                {

                    valoresNegativos[cont] = sequencia[i];       //Coloca valores negativos em vetor separado
                    cont++;                                        //Porém espaços vazios são preenchidos com 0
                }
            }

            int[] valoresNegativosDefinitiva = new int[cont];   //Transformando vetor de negativos em outro para filtrar os 0's 
            for (int i = 0; i < cont; i++)
            {


                valoresNegativosDefinitiva[i] = valoresNegativos[i];




            }
            string result = string.Join(" ", valoresNegativosDefinitiva);
            return result;
        }

      

        static void Main(string[] args)
        {

            int[] sequencia = new int[10] { -5, 1, -1, 3, 4, 40, 6, 7, 8, 9 };




            Console.WriteLine("O maior número da sequência é: " + MaiorValor(sequencia));
            Console.WriteLine("O menor número da sequência é: " + MenorValor(sequencia));
            Console.WriteLine("O valor médio da sequênica é: " + ValorMedio(sequencia));
            Console.WriteLine("Os três maiores valores da sequência são: " + MaioresValores(sequencia));
            Console.WriteLine("Números negativos: " + ValoresNegativos(sequencia));

            int[] sequenciaA = new int[10] { -5, 1, -1, 3, 4, 40, 6, 7, 8, 9 };    //Reinicia valores da sequencia
            Console.Write("Valores da sequência: ");
            for (int i = 0; i < sequenciaA.Length; i++)
            {
                Console.Write(sequenciaA[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            int numToRemove = 4;
            int numIndex = Array.IndexOf(sequenciaA, numToRemove);
            sequenciaA = sequenciaA.Where((val, idx) => idx != numIndex).ToArray();
            Console.Write("Sequencia de números com 1 número excluído: ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(sequenciaA[i]);
                Console.Write(" ");
            }
            





        }

    }
}



