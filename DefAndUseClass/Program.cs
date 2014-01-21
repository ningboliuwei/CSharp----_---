using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefAndUseClass
{
    public class MyClass
    {
        public int PublicField = 0;
        private int PrivateField = 0;
        public void PrintValue()
        {
            Console.WriteLine("PublicField="+PublicField.ToString());
            Console.WriteLine("PrivateField=" + PrivateField.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();    //创建对象
            obj.PublicField = 100;        //通过对象变量访问公有字段
            //obj.j = 200;     //Error! 不允许直接访问类的私有成员
            obj.PrintValue();   //通过对象变量访问公有方法
            Console.ReadKey();  //程序暂停
        }
    }
}
