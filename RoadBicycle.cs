using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.v.lelyavinoop.assignment3
{
    public class RoadBicycle : Bicycle
    {
        private string rigidFork;

        public RoadBicycle(string title, int price, string rigidFork) : base(title, price)
        {
            this.rigidFork = rigidFork;
        }

        public void print()
        {
            Console.WriteLine("Bicycle = " + " rigidFork " + rigidFork);
        }
    }
}
