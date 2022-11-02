using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Volatile
{
    class Program
    {
         volatile  bool  flag = true;
        static void Main(string[] args)
        {
            Program p = new Program();

            Thread th = new Thread(MyMethod);
            th.Start(p);


            Thread.Sleep(20);
            p.flag = false;
            
            Console.WriteLine("Step-2:- flag false");
            Console.Read();
        }


         static void MyMethod(object o)
        {
            Program p = (Program)o;
            Console.WriteLine("Step-1:- Inside Thread start the loop.");
            while(p.flag)
            {
                Console.WriteLine("loop");
            }
            Console.WriteLine("Step-3:- out of Loop");
        }

          
    }
}
