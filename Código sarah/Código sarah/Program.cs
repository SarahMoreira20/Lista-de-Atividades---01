// See https://aka.ms/new-console-template for more information
Console.Write("Digite sua função no escritório SF: ");
string funcao = Console.ReadLine().ToLower();

if (funcao == "advogada")
{
    Console.WriteLine("Olá Dra. Sara");
}
else if (funcao == "estagiário")
{
    Console.WriteLine("Olá Sarah / Luiz Felipe");
}
else if (funcao == "assistente administrativo")
{
    Console.WriteLine("Olá Ynara / Thamyres!");
}
else
{
    Console.WriteLine("Função não reconhecida.");
}
