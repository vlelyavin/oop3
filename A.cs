using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.v.lelyavinoop.assignment2
{
    public class A { 

        private B firstBMember;
        private B secondBMember;
        private B thirdBMember;

        public A(B firstBMember, B secondBMember)
        {
            this.firstBMember = firstBMember;
            this.secondBMember = secondBMember;
        }

        public A(B firstBMember, B secondBMember, B thirdBMember)
        {
            this.firstBMember = firstBMember;
            this.secondBMember = secondBMember;
            this.thirdBMember = thirdBMember;
        }

        public void printProperties()
        {
            Console.WriteLine("Propeties -> ");
            if(firstBMember != null)
            {
                firstBMember.doAnything();
            }
            if(secondBMember != null)
            {
                secondBMember.doAnything();
            }
            if(thirdBMember != null)
            {
                thirdBMember.doAnything();
            }
        }
    }
}
