using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUm
{
    internal class Retangulo
    {
        public double largura;
        public double altura;

        public double CalcArea()
        {
            return largura * altura;
        }

        public double CalcPeri()
        {
            return (largura * 2) + (altura * 2);
        }

        public double CalcDiag()
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
    }
}
