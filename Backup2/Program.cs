using System;
using System.Collections.Generic;
using System.Text;

namespace UseListForCS1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            List<string> strList=new List<string>();

            //加入10个元素
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
                intList.Add(ran.Next(0, 100));


              for (int i = 0; i < 10; i++)
                strList.Add(ran.Next(0, 100).ToString());

            //输出全部元素
            System.Console.WriteLine("使用泛型方法PrintListElements()输出int型List集合的所有元素：");

            PrintListElements<int>(intList);
            System.Console.WriteLine("\n");
            PrintListElements<string>(strList);

            System.Console.ReadKey();
        }

        //输出一个泛型List对象中的所有元素
        static void PrintListElements<T>(List<T> TList)
        {
             foreach (T element in TList )
            {
                Console.Write("{0},", element);
            }
        }
    }
}
