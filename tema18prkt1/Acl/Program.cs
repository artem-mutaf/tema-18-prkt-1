using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Acl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DerivedClass d = new DerivedClass();
            d.Method1();
            WriteLine(d.Method2(800, 90));
            WriteLine(d.Show("Artem Nikotinovic"));
            ReadKey();


            
        }
    }
}
