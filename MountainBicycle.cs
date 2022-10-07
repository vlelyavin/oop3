using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.v.lelyavinoop.assignment3
{
    public class MountainBicycle : Bicycle
    {

        private string suspension;

        public MountainBicycle(string title, int price, string suspension) : base(title, price)
        {
            this.SetSuspension(suspension);
        }

        public string GetSuspension()
        {
            return suspension;
        }

        public void SetSuspension(string value)
        {
            suspension = value;
        }

        public void print()
        {
            Console.WriteLine("Bicycle = " + " suspension " + suspension);
        }
    }
}
