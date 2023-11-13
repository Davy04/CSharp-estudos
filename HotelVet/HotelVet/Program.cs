using HotelVet;

Inquilino[] inquilinos = new Inquilino[10];

Console.WriteLine("quantos quartos vão ser alugados?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Aluguel #{i}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    inquilinos[quarto] = new Inquilino(nome, email);
}
Console.WriteLine();
Console.WriteLine("Quartos ocupados:  ");
for (int i = 0; i < 10; i++)
{
    if (inquilinos[i] != null)
    {
        Console.WriteLine(i + ": " + inquilinos[i]);
    }
}