
using Projeto2_Classes;

Pessoa p1, p2;
p1 = new Pessoa();
p2 = new Pessoa();

Console.WriteLine("dados da primeira pessoa: ");
Console.Write("nome: ");
p1.nome = Console.ReadLine();
Console.Write("idade: ");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("dados da segunda pessoa: ");
Console.Write("nome: ");
p2.nome = Console.ReadLine();
Console.Write("idade: ");
p2.idade = int.Parse(Console.ReadLine());

Console.Write("Pessoa mais velha: ");

if (p1.idade > p2.idade)
{
    Console.WriteLine(p1.nome);
}
else
{
    Console.WriteLine(p2.nome);
}