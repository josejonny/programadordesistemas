using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string usuario = "";
            string senha = "";
            var rg = new Regex(@" ");
            do
            {
                Console.WriteLine("Digite 0 para sair");
                usuario = Console.ReadLine();
            } while (usuario.Length == 0 || rg.IsMatch(usuario));
            do
            {
                Console.WriteLine("Digite a senha: ");
                senha = Console.ReadLine();
            } while (senha.Length < 6);*/
            bool continua = true;
            do
            { var rg = new Regex(@"^[0-9]+$");
                string textoN = "";
                do
                {
                    Console.WriteLine("Digite um número: ");
                    textoN = Console.ReadLine();
                    //int n = Convert.ToInt32(Console.ReadLine());
                } while (!rg.IsMatch(textoN));
                int n = Convert.ToInt32(textoN);

                do

                {
                    Console.WriteLine("Digite o número inicial: ");
                    textoN = Console.ReadLine();
                    //int n = Convert.ToInt32(Console.ReadLine());
                } while (!rg.IsMatch(textoN));
                int n1 = Convert.ToInt32(textoN);
                continua = false;
                do
                {
                    Console.WriteLine("Digite o número final: ");
                    textoN = Console.ReadLine();
                    //int n = Convert.ToInt32(Console.ReadLine());
                } while (!rg.IsMatch(textoN) || Convert.ToInt32(textoN) > n1);
                int n2 = Convert.ToInt32(textoN);
                while (n1 >= n2) 
                {
                    Console.WriteLine(n + " X " + n1 + " = " + (n * n1));
                    n1--;
                }
                Console.WriteLine("Digite 0 para sair: ");
                string sair = Console.ReadLine();
                if(sair == "0")
                {
                    continua = false;
                }
                
            } while (continua);
        }
    }
}
