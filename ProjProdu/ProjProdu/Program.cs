using System;
using System.Globalization;

namespace ProjProdu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine();

            Console.Write("Nome: ");
            string nomeAux = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Preço: ");
            double precoAux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Quantidade no estoque: ");
            int qtdAux = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Produto p = new Produto(nomeAux, precoAux, qtdAux);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine();

            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine();

            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}