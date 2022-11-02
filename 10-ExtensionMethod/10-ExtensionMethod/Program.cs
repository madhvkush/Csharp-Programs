using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Have to use this namespace for using extension methods
using _10_ExtensionMethod.Extensions;

namespace _10_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Madhv Singh Kushawah";
            Console.WriteLine("Lenght of {0} is=  {1}  ", str, str.Count());
            Console.WriteLine("Word count of {0} is = {1}",str, str.WordCount());

            Console.Write((1.0).IsGreaterThan(2.0));

            Console.Read();
        }
    }
}
