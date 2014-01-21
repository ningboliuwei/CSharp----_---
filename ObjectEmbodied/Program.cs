using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectEmbodied
{
    /// <summary>
    /// 被包容的对象
    /// </summary>
    class B
    {
    }

    /// <summary>
    /// 包容方式一
    /// 一般情况下，内部对象不能被外界直接访问
    /// （当然，根据需要也可以设为Public的）
    /// 要在包容类的构造函数中创建被包容对象
    /// </summary>
    class A1
    {
        private B obj;
        public A1()
        {
            obj = new B();
        }
    }

    /// <summary>
    /// 包容方式二
    /// 包容的对象由外界负责创建
    /// </summary>
    class A2
    {
        public B obj=null;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //创建第一种包容方式的对象
            //其内部已自动创建好包容的B对象
            //但外界不能直接访问
            A1 obj = new A1();

            //使用第一种包容方式的对象
            //……
            //当obj所引用的对象被销毁时，其内部对象也同时被销毁
            
            //实现第二种对象组合方式
            //创建包容器对象
            A2 container = new A2();
            //创建被包容对象
            B embodiedObj = new B();
            //实现对象包容
            container.obj = embodiedObj;

            //使用第二种包容方式的对象
            //……
            //container和obj所引用的对象其生命周期是相互独立的，
            //一个对象被销毁不会自动导致另一个对象也被销毁


        }
    }

    
}
