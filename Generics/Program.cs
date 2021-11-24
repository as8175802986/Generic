using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the generic class method
            Console.WriteLine(GenericClass.MaxNumber(100.256, 30.256, 130.0232));
        }
    }
}
