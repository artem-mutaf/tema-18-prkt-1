using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Russian:Person
    {
        public Russian() { }
        public Russian(string Name) { this.Name = Name; }
        public override void Welcome()
        {
            Console.WriteLine($"Привет {Name}");
        }
    }
}
