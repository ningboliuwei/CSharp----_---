using System;
using System.Collections.Generic;
using System.Text;

namespace UseEventExample
{
    public delegate void MyMultiDelegate(int value);

    //事件发布者类
    public class Publisher
    {
        public event MyMultiDelegate handlers; //定义一个事件
        //激发事件
        public void FireEvent()
        {
            handlers(10);
        }
    }


    //事件响应者类
    public class Subscriber
    {
        //事件处理函数
        public void MyMethod(int i)
        {
            Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();
            //声明为事件的委托无法直接调用Combine方法
            //以下两句将无法通过编译
            //p.handlers = System.Delegate.Combine(p.handlers, new MyMultiDelegate(s1.MyMethod)) as MyMultiDelegate;
            //p.handlers = System.Delegate.Combine(p.handlers, new MyMultiDelegate(s2.MyMethod)) as MyMultiDelegate;
            //必须使用＋＝运算符给事件追加委托
            //p.handlers+=new MyMultiDelegate(s1.MyMethod);
            //p.handlers+=new MyMultiDelegate(s2.MyMethod);
            p.handlers += s1.MyMethod;
            p.handlers += s1.MyMethod;
            //声明为事件的委托也不能直接调用，下面这句无法通过编译
            //p.handlers(10);
            //只能通过类的公有方法间接地引发事件
            p.FireEvent();

            Console.ReadKey();

        }
    }
}
