using System;
using System.Collections.Generic;
using System.Text;

namespace UseListForCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            //以随机数填充List集合
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
                intList.Add(ran.Next(0, 100));

            //输出全部元素
            System.Console.WriteLine("输出int型List集合的所有元素：");
            PrintListElements<int>(intList);

            Console.WriteLine("\n将int类型集合的所有元素平方，放入一个long型的List集合中。");

            //将每个元素变成它的平方值
            Converter<int, long> changer;  //定义泛型委托变量
            changer = new Converter<int, long>(GetSquare); //将函数地址传给泛型委托变量

            List<long> longList = intList.ConvertAll<long>(changer);

            //注：也可以省去上面三句，直接将GetSquare函数传给ConvertAll()方法
            //这是推荐的编码方式
            //List<long> longList = intList.ConvertAll<long>(GetSquare);

            //输出全部元素
            System.Console.WriteLine("输出long型List集合的所有元素：");
            PrintListElements<long>(longList);

            Console.ReadKey();
        }

        //输出一个泛型List对象中的所有元素
        static void PrintListElements<T>(List<T> TList)
        {
            foreach (T element in TList)
            {
                Console.Write("{0},", element);
            }
        }

        //求整数的平方
        static long GetSquare(int elem)
        {
            return elem * elem;
        }
    }
}
