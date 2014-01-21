using System;
using System.Collections.Generic;
using System.Text;

namespace CallBackExample
{
    class Controller
    {
        public List<ICallBack> CallBackObjects = new List<ICallBack>();//回调对象
        //public Controller(ICallBack obj)
        //{
        //    this.CallBackObject = obj;
        //}
       // private ICallBack CallBackObject;
           
        public void Begin()
        {
            
            Console.WriteLine("敲任意键显示当前时间，ESC键退出....");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
               // CallBackObject.run();
                foreach (ICallBack obj in CallBackObjects)
                    obj.run();
            }
         
        }


    }
}
