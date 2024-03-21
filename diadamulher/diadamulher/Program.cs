using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diadamulher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 1;
            while (i <= 8)
            {
                Console.WriteLine("Feliz Dia Internacional das Mulheres");
                i++;

            }*/
            bool continuar = true;
            while (continuar) {
                /*Console.WriteLine("Digite um Número! ");
                int n = Convert.ToInt32(Console.ReadLine());
                int cont = 0;
                while(cont <= 10)
                {
                    int produto = n * cont;
                    Console.WriteLine(produto);
                    cont++; //incrementar cont = cont + 1;
                }
                Console.WriteLine("Deseja continuar: Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Não")
                {
                    continuar = false;*/
                Console.WriteLine("Digite o 1o Número: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o 2o Número: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int resultado = n1 + n2;
                Console.WriteLine("Soma: " + resultado);
                Console.WriteLine("Deseja fazer outro cálculo? Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Não")
                {
                    continuar = false;
                }
            }
        }
    }
}
}
