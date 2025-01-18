using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class DerivedClass2 : DerivedClass1
    {

        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");

        }
    }

}
