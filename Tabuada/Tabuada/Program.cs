// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//criar um programa que escreva os números de 10 a 1 utilizabndo o while;
//
//int n = 10;

int n = 5;
int resultado = n;

//while ( n > 0)
//{
//    Console.WriteLine(n);
//   n--;//n= n - 1
//}
//criar um programa que escreva o fatorial de n;
//5! = 5 * 4 * 3 * 2 * 1 = 120
//

while ( n >= 1 )
{
    Console.WriteLine(resultado + " x " + n + " = ");
    resultado *= n;//resultado = resultado * n
    Console.WriteLine(resultado);
    n--;

}

//juros compostos usando juros simples
//juros = capital *taxa * tempo
//montante = capítal + juros
//int n = 1;

double capital = 100;
double taxa = 0.10;//10%
int tempo = 12;
int contador = 1;
double montante = 0;
double juros = 0;

//início : 100
//1o mês: 110
//2o mês: 121

Console.WriteLine("início: " + capital);
while ( contador <=tempo )
{
    juros = capital * taxa; // calculo juros
    montante = capital + juros; // calculo montante
    Console.WriteLine(contador + " o mês: " + montante);
    capital = montante; // atualiza o capital
    contador++;
}
//while (n <= 20)
//{
//    if (n % 2 == 1)
//    {
//        Console.WriteLine(n);
//    }
//    n = n + 1;
//}
string senhaDigitada;
    string senhaPadrao = "senac";
Console.WriteLine("Digite a Senha");
senhaDigitada = Console.ReadLine();

while ( senhaDigitada != senhaPadrao)
{
    Console.WriteLine("Digite a senha novamente: ");
    senhaDigitada = Console.ReadLine();
}

Console.WriteLine("Bem Vindo " );