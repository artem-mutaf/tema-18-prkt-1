using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr
{
    /// <summary>
    /// Наследуем новый класс
    /// </summary>
    class DerivedClass:AClass
    {
        
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Метод Method2 из класса AClass реализованный в классе DeriverClass");
        }
        public override void Method3()
        {
            Console.WriteLine("Method3 из класса AClass реализованный в производном классе DerivedClass");
        }
        public override void Method4()
        {
            Console.WriteLine("Method4 из класса AClass реализованный в производном классе DerivedClass ");
        }
    }
}
