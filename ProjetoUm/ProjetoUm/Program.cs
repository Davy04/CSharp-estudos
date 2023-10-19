using System;
using System.Globalization;

namespace ProjetoUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.CalcArea();

            double areaY = y.CalcArea();

            Console.WriteLine("AREA DE X: " + areaX);
            Console.WriteLine("AREA DE Y: " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("O Triangulo X é maior");
            }
            else
            {
                Console.WriteLine("O Triangulo Y é maior");
            }
        }
    }
}