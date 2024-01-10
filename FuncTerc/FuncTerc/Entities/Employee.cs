using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncTerc.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public int ValuePerHour {  get; set; }

        public Employee() { }

        public Employee(string name, int hours, int valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
