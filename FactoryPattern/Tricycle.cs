using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Tricycle : IVehicle
    {
        public Tricycle() { }

        public void Drive()
        {
            Console.WriteLine("Building a Tricycle!");
        }
    }
}
