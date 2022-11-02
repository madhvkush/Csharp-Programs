using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Delegate_MltiCasting_
{
    delegate void DisplayVoidDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayVoidDelegate dl = new DisplayVoidDelegate(Show1);
            //dl += Show2;

            //DisplayVoidDelegate dl = Show1;
            //dl += Show2;
            //dl -= Show1;

            DisplayVoidDelegate dl1 = new DisplayVoidDelegate(Show1);
            DisplayVoidDelegate dl2 = new DisplayVoidDelegate(Show2);

            DisplayVoidDelegate dl = dl1 + dl2;

            dl.Invoke();
            Console.Read();
        }

        static void Show1()
        {
            Console.WriteLine("Show-1");
        }
        static void Show2()
        {
            Console.WriteLine("Show-2");
        }
    }

}
