using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overrides
{
    class Parent
    {
        public virtual void OverrideF()
        {
            System.Console.WriteLine("Parent.OverrideF()");
        }
    }
    class Child : Parent
    {
        public override void OverrideF()
        {
            System.Console.WriteLine("Child.OverrideF()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();

            p.OverrideF();
            c.OverrideF();

            p = c;  //基类变量引用子类对象
            p.OverrideF();  //会输出什么结果？

            (p as Parent).OverrideF();//会输出什么结果？
         

            Console.ReadKey();
        }
    }
}
