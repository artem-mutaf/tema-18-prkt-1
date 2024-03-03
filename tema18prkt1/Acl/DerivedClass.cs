using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acl
{
    /// <summary>
    /// Обычный класс который явл. наследником CClass
    /// </summary>
    class DerivedClass:CClass
    {
        /// <summary>
        /// Переопред метод из класса AClass
        /// </summary>
        public override void Method1()
        {
            Console.WriteLine("Это просто метод Method1");
        }
        /// <summary>
        /// Переопределенный метод из класса BClass где ,
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public override int Method2(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Переопределенный метод из класса CClass
        /// </summary>
        /// <param name="zdaro"></param>
        /// <returns></returns>
        public override string Show(string zdaro)
        {
            return $"Привет {zdaro}";
        }
    }
}
