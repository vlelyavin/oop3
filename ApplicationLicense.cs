using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.v.lelyavinoop.assignment3
{
    public class ApplicationLicense{

        public void verifyUserKey(int userKey) {
            
            if (userKey == 0) {
                allowTrial();
            } else if (userKey == 1) {
                allowCommon();
            } else if (userKey == 2) {
                allowPro();
            }
        }

        public void allowTrial(){
            Console.WriteLine("Trial version");
        }

        public void allowCommon()
        {
            Console.WriteLine("Common version");
        }

        public void allowPro()
        {
            Console.WriteLine("Pro version");
        }
    }
}
