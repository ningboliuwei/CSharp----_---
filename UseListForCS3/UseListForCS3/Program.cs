using System;
using System.Collections.Generic;
using System.Text;

namespace UseListForCS3
{
    //类A的对象可以比较大小
    public class A : IComparable<A>
    {
        public int i = 0;
        //实现泛型接口IComparable<T>
        int IComparable<A>.CompareTo(A other)
        {
            if (this.i > other.i)
                return -1;

            if (this.i == other.i)
                return 0;

            return 1;
        }
        //覆盖Object类的ToString（）方法
        public override string ToString()
        {
            return i.ToString();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.WriteLine("生成一个类型为A的List集合并随机填充其内容：");

            List<A> AList = new List<A>();
            A temp = null; //临时变量
            //加入元素
            for (int i = 0; i < 10; i++)
            {
                temp = new A();
                temp.i = ran.Next(0, 100); //使用0～100间的随机数
                AList.Add(temp);
            }

            foreach (A element in AList)
            {
                Console.Write("{0},", element.i);
            }

            //排序
            AList.Sort();

            //输出全部元素
            Console.WriteLine("\n类型为A的List集合排序后的结果：");
            PrintListElements<A>(AList);

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
    }
}
