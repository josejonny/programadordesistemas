using System;

namespace For1a10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine(cont);
            }//escopo
            Console.WriteLine(" Digite um número. ");
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            while (cont <= 10)
            {
                int produto = n * cont;
                Console.WriteLine(n + "X" + cont + "=" + produto);
                cont++;
            Console.WriteLine("Eleição");
            int goku = 0;
            int vegeta = 0;
            for (int cont = 1; cont <=3; cont++)
            {
                Console.WriteLine("Digite 1.Goku ou 2.Vegeta: ");
                int voto = Convert.ToInt32(Console.ReadLine());
                if (voto == 1)
                {
                    goku = goku + 1;
                }
                else { vegeta = vegeta + 1; }
            }if (goku > vegeta)
            {
                Console.WriteLine("Goku ganhou!");
            }
            else
            {
                Console.WriteLine("Vegeta ganhou!");
            }*/

            Console.WriteLine("Digite o 1o Termo");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a razão");
            int razao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de termos");
            int n = Convert.ToInt32(Console.ReadLine());
            //int cont = 1;
            int pa = n1;
            for (int cont = 1; cont <= n; cont++)
            {
                Console.WriteLine(pa);
                pa = pa + razao;
            }
        }
        
    }
    }

