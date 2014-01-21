using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseProperty
{
    public class People
    {
        public string Name = "";

        /// <summary>
        /// 年龄属性，要求必须大于0
        /// </summary>
        private int _age = 0;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                    _age = 0;
                else
                    _age = value;
            }
        }
        /// <summary>
        /// C# 3.0提供的默认属性实现机制
        /// 但没有提供验证数据有效性的功能
        /// </summary>
        //public int Age2
        //{
        //    get;
        //    set;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            People p = new People();
            //p.Age = 32; //OK!
            //Console.WriteLine("The people is {0} years old.", p.Age);
            p.Age = -1; //自动截取为0值
            Console.WriteLine("The people is {0} years old.", p.Age);

            //p.Age2 = 100; //只适用于C# 3.0以上版本
            //Console.WriteLine("The people is {0} years old.", p.Age2);

            Console.ReadKey();
        }
    }
}
