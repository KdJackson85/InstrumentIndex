using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Brass frenchhorn = new Brass("F2", 12, 5);

            frenchhorn.displayStats();

            Console.ReadLine();
        }
    }
}
