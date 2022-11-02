using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Delegate_FunctionPointer_
{
   public class Program
    {
        public delegate int PerformCalculation(int x, int y);
        
        // ADD
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        //Subtract
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        //Multiplication
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        //Division
        public static int Division(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            PerformCalculation Pointer;
             Pointer = Add;
            Console.WriteLine("Addition:-{0}", Pointer(5,2));
            Pointer = Subtract;
            Console.WriteLine("Subtract:-{0}", Pointer(5, 2));
            Pointer = Multiplication;
            Console.WriteLine("Multiplication:-{0}", Pointer(5, 2));
            Pointer = Division;
            Console.WriteLine("Division:-{0}", Pointer(5, 2));

            Console.Read();

        }
    }
}
