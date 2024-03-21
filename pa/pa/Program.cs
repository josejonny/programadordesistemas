// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace pa
{
    internal class program
{
    static void Main(string[] args);
    int n1 = Convert.ToInt32(Console.ReadLine());
    int razao = Convert.ToInt32(Console.Read());
    int n = Convert.ToInt32(Console.ReadLine());
    int cont = 1;
    int pa = n1;
    while (cont <= n)
        {
        Console.WriteLine(pa);
        pa = pa + razao;
        cont++;
}
}


