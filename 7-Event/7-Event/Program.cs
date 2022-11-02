using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Event
{
    public delegate void Transaction(double RemainigBalance);
    public class BankAccount
    {
        public BankAccount(double DepositMoney)
        {
            this.AvailableMoney = DepositMoney;
        }
        public double AvailableMoney { get; set; }
        public event Transaction OnTrasctionSuccess;
        public event Transaction OnTrasctionFailed;
        public void MakeTransaction(double Money)
        {
            if(this.AvailableMoney>=Money)
            {
                this.AvailableMoney -= Money;
               OnTrasctionSuccess(this.AvailableMoney);//Invoke Success transaction event
            }
            else
            {
                OnTrasctionFailed.Invoke(this.AvailableMoney);// Invoke transaction failure event
            }
        }

        
    }

    class Program
    {
        //Ref:- http://www.tutorialsteacher.com/csharp/csharp-event
        static void Main(string[] args)
        {
            BankAccount bnk = new BankAccount(50000);
            Console.WriteLine("Currently Available amount:-" + bnk.AvailableMoney);
            //make transaction
            EnterAmount: Console.Write("Enter Amount to be deducted:-"); 
            double Amount = 0.0;
            try
            {
               
                 Amount = Convert.ToDouble(Console.ReadLine());
            }
            catch { Console.WriteLine("Only Numeric is allowed"); goto EnterAmount; }

            bnk.OnTrasctionSuccess += Bnk_OnTrasctionSuccess;
            bnk.OnTrasctionFailed += Bnk_OnTrasctionFailed;
            //Note:- Susbcribe event before MakeTransaction; otherwise events would not be fired

            bnk.MakeTransaction(Amount); // Event fires on trasaction compltion or failure

           

            Console.Read();
        }

        private static void Bnk_OnTrasctionFailed(double RemainigBalance)
        {
            Console.WriteLine("Trasaction Failed. Available balance:- " + RemainigBalance);
             
        }

        private static void Bnk_OnTrasctionSuccess(double RemainigBalance)
        {
            Console.WriteLine("Trasaction Successfully completed. Available balance:- " + RemainigBalance);
           
        }
    }
}
