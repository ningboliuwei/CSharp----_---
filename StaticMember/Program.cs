using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticMember
{
    class StaticClass
    {
        public static int staticProp = 100;
        public static void staticFunc()
        {
            Console.WriteLine("静态方法");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //访问静态属性
            StaticClass.staticProp = 1000;
            Console.WriteLine(StaticClass.staticProp);
            //访问静态方法
            StaticClass.staticFunc();
            Console.ReadKey();
        }
    }
}
