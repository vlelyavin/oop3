using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.v.lelyavinoop.assignment1
{
    public class WhitePrinter : ColorPrinter {

        public override void printInColor(string value){

            Console.WriteLine(value + " this is " + value.GetType().Name, 
                Console.ForegroundColor = ConsoleColor.White); 
        }
    }
}
