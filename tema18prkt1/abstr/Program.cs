using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            DerivedClass cls = new DerivedClass();
            cls.Method1();
            cls.Method2();
            cls.Method3(); 
            cls.Method4();
            Console.WriteLine("");
            AClass acls = new DerivedClass();
            acls.Method1();
            acls.Method2(); 
            acls.Method3();
            acls.Method4();

            Console.ReadKey();

        }
    }
}
