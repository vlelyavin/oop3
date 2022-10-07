using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.v.lelyavinoop.assignment3
{
    public class Bicycle{

        private string title;
        private int price;

        public Bicycle(string title, int price)
        {
            this.SetTitle(title);
            this.SetPrice(price);
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }

        public int GetPrice()
        {
            return price;
        }

        public void SetPrice(int value)
        {
            price = value;
        }

        public void print()
        {
            Console.WriteLine("title " + title + " price " + price);   
        }


    }
}
