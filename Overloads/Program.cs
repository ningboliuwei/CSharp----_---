using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloads
{
    class Parent
    {
        public void OverloadF()
        {
            Console.WriteLine("Parent.OverloadF()");
        }
    }
    class Child : Parent
    {
        public void OverloadF(int i)
        {
            Console.WriteLine("Child.OverloadF(i); i="+i.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.OverloadF();
            c.OverloadF(100);
            Console.ReadKey();
        }
    }
}
