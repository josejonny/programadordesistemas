﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleição");
            
            //
            //int voto = Convert.ToInt32(Convert.ReadLine());
            int cont = 1;
            //int goku = 0;
            //int vegeta = 0;
            int soma = 0;
            while(cont <= 3)
            {
                /*Console.WriteLine("Digite 1.Goku ou 2.Vegeta:");
                int voto = Convert.ToInt32(Console.ReadLine());
                if (voto == 1)
                {
                    goku = goku + 1;
                }
                else
                {
                    vegeta = vegeta + 1;
                }
                cont++;
            }
            if (goku > vegeta)
            {
                Console.WriteLine("Goku ganhou!");
            }
            else
            {
                Console.WriteLine("Vegeta ganhou!");*/
                Console.WriteLine("Digite um número");
                int resposta = Convert.ToInt32(Console.ReadLine());
                soma = soma + resposta;
                cont++;
            }
            Console.WriteLine("Soma: " + soma);

        }
    }
}
