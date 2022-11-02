using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Action
{
    //Ref:- http://www.tutorialsteacher.com/csharp/csharp-action-delegate
    class Program
    {
        //Note:- it is same as Func but it have no return type. 
        // it always points to void type methods
        Action<double, double> Caculation;  //delegate void Caculation(double a, double b);

        static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine("Enter First Number:- ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number:- ");
            double y = Convert.ToDouble(Console.ReadLine());

            p.Caculation = p.Addition; // calculation point to addition
            p.Caculation += p.Subtraction; //  now subtraction aslo attached to this pointer

            p.Caculation(x, y);

            Console.Read();
        }

        public void Addition(double a, double b)
        {
            Console.WriteLine("Addition:= "+(a + b).ToString());
        }
        public void Subtraction(double a, double b)
        {
            Console.WriteLine("Subtraction:= " + (a - b).ToString());
        }
    }
}
