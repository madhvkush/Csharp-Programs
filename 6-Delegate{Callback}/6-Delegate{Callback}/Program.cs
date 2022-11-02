using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Delegate_Callback_
{
    class Program
    {
        delegate void MDelegate(string BackValue);
        static void Main(string[] args)
        {

            CallingMethod("Madhv", CallBackMethod);
            Console.Read();
        }

        static void CallingMethod(string InputValue, MDelegate CallBack)
        {
            #region Perform Logical Calculation
            string ValueToBeBack = "Hello "+InputValue;
            #endregion
            // Now after finish calculation/work give back call.
            CallBack(ValueToBeBack);
        }

        static void  CallBackMethod(string BackValue)
        {
            Console.WriteLine("Calling Back. Return-Value:- " + BackValue);
        }
    }
}
