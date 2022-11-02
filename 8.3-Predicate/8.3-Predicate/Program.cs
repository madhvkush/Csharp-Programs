using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Predicate
{
    //REf:- http://www.tutorialsteacher.com/csharp/csharp-predicate
    class Program
    {
        //Note:- Predicate is also same as Func and Action delegates but 
        // it takes one parameter and returns bool


        Predicate<string> isUpper;// delegate bool isUpper(string str);


        static void Main(string[] args)
        {
            Program p = new Program();
            p.isUpper = p.IsUpperCase; // isUpper delegate pointing to the method IsUppercase

            string str = "hello word isUpper  ";
            Console.WriteLine("{0} :- {1} ", str, p.isUpper(str));

             str = "HELLO WORLD ISUPPER";
            Console.WriteLine("{0} :- {1} ", str, p.isUpper(str));

            Console.Read();
        }


        bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

    }
}
