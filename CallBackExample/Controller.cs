using System;
using System.Collections.Generic;
using System.Text;

namespace CallBackExample
{
    class Controller
    {
        public List<ICallBack> CallBackObjects = new List<ICallBack>();//�ص�����
        //public Controller(ICallBack obj)
        //{
        //    this.CallBackObject = obj;
        //}
       // private ICallBack CallBackObject;
           
        public void Begin()
        {
            
            Console.WriteLine("���������ʾ��ǰʱ�䣬ESC���˳�....");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
               // CallBackObject.run();
                foreach (ICallBack obj in CallBackObjects)
                    obj.run();
            }
         
        }


    }
}
