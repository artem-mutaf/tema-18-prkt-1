using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acl
{
    /// <summary>
    /// Абстрактный класс наследник BClass
    /// </summary>
    abstract class CClass:BClass
    {
        /// <summary>
        /// Абстрактный метод для вывода приветствия
        /// </summary>
        /// <param name="zdaro">zdaro</param>
        /// <returns>zdaro</returns>
        public abstract string Show(string zdaro);
        
    }
}
