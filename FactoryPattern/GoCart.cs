using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class GoCart : IVehicle
    {
        public GoCart() { }

        public void Drive()
        {
            Console.WriteLine("Building a Go-Kart!");
        }
    }
}
