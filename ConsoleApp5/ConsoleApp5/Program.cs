using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo[] nomeDoArray = new tipo [tamanho_do_array];
            int[] numeros = new int [5];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número:");
                numeros[1] = Convert.ToInt32(Console.ReadLine());
            }
            for ( int j = 0; j < numeros.Length; j++)
            {
                Console.WriteLine("número ( " + (j + 1) + "): " + numeros[j]);
            }
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" A Soma dos Números é: ");
                soma = soma + numeros[i];
            }


            /*numeros[0] = 25;
            Console.WriteLine("numero 0");*/
            {
                
            }

        }
    }
}
