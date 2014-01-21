using System;
using System.Collections.Generic;
using System.Text;

namespace UseMultiDelegateExample
{
    public delegate void MyMultiDelegate(int value );

    //事件发布者类
    public class  Publisher 
    {
        public MyMultiDelegate handlers; //事件响应者清单
    }

   
    //事件响应者类
    public class Subscriber
    {
        //事件处理函数
        public void MyMethod(int i )
        {
            Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //一个事件源对象
            Publisher p = new Publisher();
            //两个事件响应者
            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();
            //可以直接调用Delegate类的静态方法组合多个委托
            p.handlers = System.Delegate.Combine(p.handlers, new MyMultiDelegate(s1.MyMethod)) as MyMultiDelegate;
            p.handlers = System.Delegate.Combine(p.handlers, new MyMultiDelegate(s2.MyMethod)) as MyMultiDelegate;
            //或调用＋＝运算符组合委托
            //p.handlers += new MyMultiDelegate(s1.MyMethod);
            //p.handlers += new MyMultiDelegate(s2.MyMethod);
            //最简单的写法
            //p.handlers += s1.MyMethod;
            //p.handlers += s2.MyMethod;
            
            //直接调用委托变量，代表激发事件
            p.handlers(10);

            Console.ReadKey();

        }
    }
}
