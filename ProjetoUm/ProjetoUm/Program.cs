using System;
using System.Globalization;

namespace ProjetoUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do Retangulo: ");
            Console.Write("altura: ");
            ret.altura = double.Parse(Console.ReadLine());

            Console.Write("largura: ");
            ret.largura = double.Parse(Console.ReadLine());

            double area = ret.CalcArea();

            Console.WriteLine("AREA: " + area);

            double peri = ret.CalcPeri();

            Console.WriteLine("PERIMETRO: " + peri);

            double diag = ret.CalcDiag();

            Console.WriteLine("DIAGONAL: " + diag);


        }
    }
}