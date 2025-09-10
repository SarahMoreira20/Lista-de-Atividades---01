
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o número de maçãs que você comprou: ");
int numMacas = int.Parse(Console.ReadLine());
double preco;

if (numMacas < 12)
{
    preco = 1.30;
}
else
{
    preco = 1.00;
}

double total = numMacas * preco;

Console.WriteLine($"O valor da compra é de R$ {total}");