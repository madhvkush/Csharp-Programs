using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Func
{
    //REf:- http://www.tutorialsteacher.com/csharp/csharp-func-delegate
    class Program
    {
        Func<double, double, string> Caculation;  //delegate string Caculation(double a, double b);

        // this Func would be equivalent
        //delegate string Caculation(double a, double b);

            //Note:- Last parameter is always return type in Func. 
            //Note:- parameter cant be void, thats why this delegate always return somthing. 

        static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine("Enter First Number:- ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number:- ");
            double y = Convert.ToDouble(Console.ReadLine());

            p.Caculation = p.Addition; // calculation performs to addition
            Console.WriteLine("Addition:= " + p.Caculation(x, y));

            p.Caculation = p.Subtraction; // Now calcualtion points to subtraction
            Console.WriteLine("Subtraction:= " + p.Caculation(x, y));

            Console.Read();
        }

        public  string Addition(double a, double b)
        {
            return (a + b).ToString();
        }
        public string Subtraction(double a, double b)
        {
            return (a - b).ToString();
        }
    }
}
