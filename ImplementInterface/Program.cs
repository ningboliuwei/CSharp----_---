using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementInterface
{
    interface IOne
    {
        void f();
    }
    //显式实现接口
    class A : IOne
    {
        #region IOne 成员

        void IOne.f()
        {
            Console.WriteLine("IOne.f()");
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            //obj.f();  //Error!不能通过对象引用调用显式实现的接口方法
            IOne iobj = obj;
            iobj.f();   //显式实现的接口方法只能通过接口变量调用
            Console.ReadKey();

        }
    }
}
