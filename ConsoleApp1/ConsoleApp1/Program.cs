// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
//string[] alunos = new string[5]
//{ "João", "Pedro", "Maria", "Ana", "Bia" };
// [], [], [], [], [], [];
//Console.WriteLine(alunos[2]);
//alunos[2] = " Osmarina";
//Console.WriteLine(alunos[2]);
//int cont = 0;
//while ( cont < 5 )
//{
//    Console.WriteLine(alunos[cont]);
//    cont++;
//}
//Criar um vetor com 5 números
//Escrever os números
//double[] números = new double[10]
//    { 1,2,3,4,5,6,7,8,9,10};
//int cont = 0;

//while (cont < 10 )
//{
//    Console.WriteLine(números[cont]);
//    cont++;
//}
//1.Criar um vetor que armazene 3 notas e realizar a soma das notas;
//1.1.Criar um vetor que soma 4 notas e realizar a média das notas;
//1.2.Informe as notas maiores que seis;
//2.Criar dois vetores um com nome e outro com notas
//e escrever o nome e as notas;
//double[] notas = new double[10]
//    { 10,8.6,5.4,0,7,6,4,3,2,1};
//int i = 0;
//double total = 0;
//double media = 0;
//while ( i < 10 )
//{
//    Console.WriteLine(notas  [i] );
//        total += notas[i];
//        i++;
//}
//media = total / 10;
//Console.WriteLine(media);
//1.Criar um vetor de 10 números na ordem inversa de sua posição;
//2.Criar um vetror com 10números e informar qual o maior;
//3.Criar dois vetores umcom nomes e outro com notas.
//Escrever os nomes e as notas;
//int[] numeros = new int[10]
//    { 1,20,13,4,52,6,17,28,19,10};
//int cont = 0;//última posição do vetior
//int maior = numeros[0];
//while ( cont < 10)//parar na primeira posição
//{
//    Console.WriteLine (numeros[cont]);
//    if (numeros[ cont ] > maior)
//    {
//        maior = numeros[cont];
//    }
//    cont++;//decrementar de 1 em 1
//}
//Console.WriteLine(" o maior número é " + maior);
//int[] n = new int[3]
//    {4,5,6 };
//int cont = 0; //inicialização
//while (cont < 3) // condição
//{
//    Console.WriteLine(n[cont]);
//    cont++;//incremento
//}
//int[] n = new int[10]
//    {13,4,5,6,7,8,9,10,11,12 };
//int maior = n[0];
//for ( int cont = 0; cont < 10; cont++ )
//{
//    Console.WriteLine (n [ cont ]);
//    if (n[cont] > maior)
//        maior = n[cont];
//}
//Console.WriteLine(" o maior número é " + maior);
// inicializção, condição e incremento juntos;
//Exercício
//Crie dois vertores com nomes e outro com notas; 
//Escreva os noms e as notas;
//Verificar se o aluno está aprovado ou reprovado;
//String[] nomes = new string[3] { " Euclides ", " José ", " Biu Gugites " };
//double[] notas = new double[3] { 8, 10, 6  };
//for ( int cont = 0; cont < 3; cont++)
//    {
//    Console.Write ( " nome " + nomes[cont] + " nota " + notas[cont] );
//   /*if (notas[cont] < 7) 
//    {
//        Console.WriteLine(" Reprovado");
//    }
//       else
//    {
//        Console.WriteLine(" Aprovado");
//    }*/
//    Console.WriteLine (notas [cont] < 7  ? " Reprovado " : " Aprovado ");
//}
//DateTime agora = DateTime.Now;
//Console.WriteLine(" Agora: {0}", agora.ToLongDateString());
//String saudacao;
//saudacao = agora.Hour > 12 ? " Boa Tarde " : " Bom Dia";
//Console.WriteLine(" São {0} horas", agora.Hour, agora.Minute);
//Console.WriteLine(saudacao);
//Console.ReadKey();
//A = Valor inicial (1);
//R = o ritmo de crescimento (3);
//10 números
//1,4,7, 10, 13, 16, 19, 22, 25, 28
//int A = 1;
//int R = 3;
//int valor = A;
//for (int A =1, R =3, valor = A, i = 0; i < 10; i++, valor +=R)
//{
//    Console.WriteLine(valor);
//    valor += R;//valor = valor + R
//}
///*void SelectionSort (int[] vetor)
//{ 
//    int min, aux;
//    for ( int i =0; i < vetor.Length-1: i++)
//{
//    min = i;
//    for ( int j = ( i+1); j < vetor.Length; j++)
//    {
//        if (vetor[j] < vetor[min])
//        {
//            min = j;
//
//        }
//    }
//    if ( vetor[1] ! = vetor[min] )
//    {
//        aux = vetor[1];
//        vetor[1] = vetor[min];
//        vetor[min] = aux;
//    }
//}
//}*/
//ler qual operação o usuário deseja realizar
//( 1.soma, subtração )
int resultado = 0;
int op = 0;
while (op != 3)
{
    Console.WriteLine("Digite a opção desejada: \n 1.soma 2.subtração 3.Sair");
    op = int.Parse(Console.ReadLine());
    if (op == 3) { break; }

    Console.WriteLine(" Escreva um número ");
    int n1 = int.Parse(Console.ReadLine());
    //Console.WriteLine("Você digitou " + n1);
    //ler um segundo número
    Console.WriteLine("Escreva outro número");
    int n2 = int.Parse(Console.ReadLine());
    if (op == 1) { resultado = n1 + n2; }
    else if (op == 2) { resultado = n1 - n2; }
    else { Console.WriteLine(" Opção inválida "); }
    Console.WriteLine(" Resultado: " + resultado);
    //spmar os dois números
    //int soma = n1 + n2;
    //ecrever a soma
    //Console.WriteLine("Soma: " + soma);
}