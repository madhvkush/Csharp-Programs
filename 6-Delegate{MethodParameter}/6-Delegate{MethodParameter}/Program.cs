using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Delegate_MethodParameter_
{
    class Program
    {
        public delegate void PerformCalculation(int x, int y);
        public void PrintHelper(PerformCalculation Pointer,int x,int y)
        {
            Pointer(x, y); // This call back execute the anonymous method's definition
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            // Pass anonymous method with definition   {Note:- Anonymous method like a paramerter}
            p.PrintHelper(delegate (int a, int b) { Console.WriteLine("Addition: {0}", a + b); }, 3, 2);

            p.PrintHelper(delegate (int a, int b) { Console.WriteLine("Subtraction: {0}", a - b); }, 3, 2);

            Console.Read();
        }
    }
}
