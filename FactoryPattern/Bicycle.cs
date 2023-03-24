using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bicycle : IVehicle
    {
        public Bicycle() { }

        public void Drive()
        {
            Console.WriteLine("Building a Bicycle!");
        }
    }
}
