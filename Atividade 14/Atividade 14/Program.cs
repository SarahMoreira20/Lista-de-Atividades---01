// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite um número maior que ZERO");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"\nNúmeros de 1 até {N}:");

for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i);
}
