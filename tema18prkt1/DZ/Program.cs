﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Russian("Artem");
            pers.Welcome();

            Console.ReadKey();
        }
        
    }
}
