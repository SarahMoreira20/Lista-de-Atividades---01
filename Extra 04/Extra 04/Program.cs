// See https://aka.ms/new-console-template for more information
Console.WriteLine("Me diga o preço do produto");
double preco = double.Parse(Console.ReadLine());
Console.WriteLine($"O preço do produto com desconto será: R${preco * 0.95}");

