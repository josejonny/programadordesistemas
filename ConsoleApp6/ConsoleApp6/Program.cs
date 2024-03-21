using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Criar vetor respostas
            string[] respostas = new string[3];
            //Criar vetor gabarito
            string[] gabarito = new string[3] { "a", "c", "d" };
            //Escrever as questões
            Console.WriteLine("1. Qual opção contém um comando: " +
                " de estrutura de repetição: ");
            Console.WriteLine("a. for");
            Console.WriteLine("b. int número");
            Console.WriteLine("c. if");
            Console.WriteLine("d. new string[3]");
            Console.WriteLine("Resposta: ");
            respostas[0] = Console.ReadLine();

            Console.WriteLine("2. Qual a última posição do vetor: " +
                " string[] respostas = new string[3]; ");
            Console.WriteLine("a. 0");
            Console.WriteLine("b. 1");
            Console.WriteLine("c. 2");
            Console.WriteLine("d. 3");
            Console.WriteLine("Resposta: ");
            respostas[1] = Console.ReadLine();

            Console.WriteLine("3. Para que serve o while: ");
            Console.WriteLine("a. Armazenar Dados");
            Console.WriteLine("b. Instânciar classes");
            Console.WriteLine("c. Declarar Variável");
            Console.WriteLine("d. Estrutura de Repetição");
            Console.WriteLine("Resposta: ");
            respostas[1] = Console.ReadLine();
            //a cada questão coletar a resposta
            //verifica quantas respostas estão corretas
            int cont = 0;
            for (int i = 0; i < respostas.Length; i++)
            {
                if (respostas[i] == gabarito[1])
                {
                    cont++; 
                }
                
            }
            //informar quantas respostas estão corretas
            Console.WriteLine("Você acertou " + cont + "questões.");*/
            string[] nomes = new string[16] { "AAaA", "aAaa", "aaAa", "aaaA", "AaAa", "AaAA", "AAAA", 
                "Aaaa", "aaaa", "aAaA", "AaaA", "aAAa", "aAAA", "aaAA", "AAaa", "AAAa" };
            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine();
            string resultado = "Não achei!";
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(resultado);
            }
            //pedir para o usuário escolher o tamanho do vetor
            //criar o vetor do tamanho escolhido
            //preencher vetor com núumeros aleatórios
            //verificar se é par
            //inserir os números pares em um vetor
            //inserir os números impares em outro vetor
            //ordenar vetor em ordem crecente (sort)
            //ordenar vetor impar em ordem decrescente
            //passa os valores do vetor par para o vetor principal
            //passa os valores do vetor impar para o vetor principal
            //obs.: obrigatório utilizar: for e vetor

            }
        }
    }
}
