using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acl
{
    abstract class BClass:AClass
    {
        /// <summary>
        /// Абстрактный метод 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public abstract int Method2(int a,int b);
    }
}
