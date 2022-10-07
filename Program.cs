using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Oop.v.lelyavinoop.assignment1;
using Task3Oop.v.lelyavinoop.assignment2;
using Task3Oop.v.lelyavinoop.assignment3;

namespace Task3Oop.v.lelyavinoop
{
    public class Program{

        public static void Main(string[] args)
        {
            // first assignment

            ColorPrinter grayPrinter = new GrayPrinter();
            grayPrinter.printInColor("Fooooee");

            ColorPrinter yellowPrinter = new YellowPrinter();
            yellowPrinter.printInColor("John Doe"); 

            ColorPrinter whitePrinter = new WhitePrinter();
            whitePrinter.printInColor("Hello World");

            //second assignment

            B firstMember = new CFromB();
            B secondMember = new DFromB();
            B thirdMember = new GFromB();
            A a = new A(firstMember, secondMember);
            a.printProperties();
            Console.WriteLine();
            A anotherA = new A(firstMember, secondMember, thirdMember);
            anotherA.printProperties();

            //third assignment

            Bicycle mountainBicycle = new MountainBicycle("Specialized", 10000, "rear + front");
            mountainBicycle.print();
            Bicycle roadBicycle = new RoadBicycle("Pinarello", 12000, "rigid fork");
            roadBicycle.print();


            ApplicationLicense verifer = new ApplicationLicense();
            Console.WriteLine("Trial period = 0\n " +
                              "Common version = 1\n " +
                              "Pro version = 2\n ");
            int programKey = Convert.ToInt32(Console.ReadLine());
            verifer.verifyUserKey(programKey);
            // it`s only a simulation of application key access.
            // In real application I wouldn`t do like this))
        }
    }
}
