using System;
using System.Linq;

namespace Atv_7
{
    internal class Program
    {

        static int MaiorValor(ref int[] sequencia)
        {

            int maiorValor = int.MinValue;

            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] > maiorValor)
                {
                    maiorValor = sequencia[i];
                }
            }
            return maiorValor;
        }


        static int MenorValor(out int[] sequencia)
        {
             sequencia = new int[] { -5, 1, -1, 3, 4, 40, 6, 7, 8, 9 };
            int menorValor = sequencia[0];

            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] < menorValor)         //Separa menor valor
                {
                    menorValor = sequencia[i];        //Armazena menor valor
                }
            }
            return menorValor;
        }


        static double ValorMedio(int[] sequencia)
        {
            double valorMedio = 0;
            for (int i = 0; i < sequencia.Length; i++)
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
            for (int j = 0; j < sequencia.Length; j++)
            {

                for (int i = 0; i < sequencia.Length - 1; i++)
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
            for (int i = 0; i < maioresValores.Length; i++)
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

            for (int i = 0; i < sequencia.Length; i++)
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
            string resultado = string.Join(" ", valoresNegativosDefinitiva);
            return resultado;
        }

      

        static void Main(string[] args)
        {

            int[] sequencia = new int[10] { -5, 1, -1, 3, 4, 40, 6, 7, 6, 9 };
            int[] sequenciaA = new int[10];  //Copia valores da sequencia original
            sequenciaA = sequencia;


            Console.WriteLine("O maior número da sequência é: " + MaiorValor(ref sequencia));
            Console.WriteLine("O menor número da sequência é: " + MenorValor(out sequencia));
            Console.WriteLine("O valor médio da sequênica é: " + ValorMedio(sequencia));
            Console.WriteLine("Os três maiores valores da sequência são: " + MaioresValores(sequencia));
            Console.WriteLine("Números negativos: " + ValoresNegativos(sequencia));

               
            Console.Write("Valores da sequência: ");        //Usando a segunda array q copia os valores originais da primeira que encontrasse filtrada
            for (int i = 0; i < sequenciaA.Length; i++)
            {
                Console.Write(sequenciaA[i]);
                Console.Write(" ");
            }     
            Console.WriteLine();
            Console.WriteLine("Digite o número a ser excluído: ");
            int numParaRemover = Int32.Parse(Console.ReadLine()); ;
            
            int numIndex = Array.IndexOf(sequenciaA, numParaRemover);
            sequenciaA = sequenciaA.Where((val, idx) => idx != numIndex).ToArray();
            Console.Write("Sequencia de números com número(s) excluído(s): ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(sequenciaA[i]);
                Console.Write(" ");
            }

            




        }

    }
}



