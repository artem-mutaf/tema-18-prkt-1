using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class AClass
    { 

        /// <summary>
        /// Обычный метод
        /// </summary>
        public void Method1()
        {
            Console.WriteLine("Обычный метод Method1 из абстрактоног класса AClass");
        }
        /// <summary>
        /// Виртуальный метод
        /// </summary>
        public virtual void Method2()
        {
            Console.WriteLine("Виртуальный метод Method2 из абстрактоного класса AClass");
        }
        /// <summary>
        /// Абстрактный метод
        /// </summary>
        public abstract void Method3();
        public abstract void Method4();
       
        
    }
}
