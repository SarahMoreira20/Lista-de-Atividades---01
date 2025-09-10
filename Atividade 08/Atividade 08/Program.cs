// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Escreva uma valor que não seja zero");
int valor = int.Parse(Console.ReadLine());

    if (valor == 0)
    {
        Console.WriteLine("Valor inválido.Zero não é permitido!");
    }
    else if (valor > 0)
    {
        Console.WriteLine("O valor é positivo!");
    }
    else
    {
    Console.WriteLine("O valor é negativo!");
    }