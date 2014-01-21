using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Default constructor");
        }
        public MyClass(string info)
        {
            Console.WriteLine("MyClass(string):" + info);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj = new MyClass("Hello");
            Console.ReadKey();
        }
    }
}
