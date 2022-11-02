using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ObjectPropertiesMethods
{
    public class A
    {
        public int x;
        public int y;
        public void Initialize(int a, int b)
        {
            this.x = a+1;
            this.y = b;
        }
        public void Print()
        {
            Console.WriteLine("a=" +y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Initialize(2, 3);
            Console.WriteLine("x=" + a.x);
            a.Print();
            Console.Read();
        }
    }
}
