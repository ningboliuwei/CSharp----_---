using System;
using System.Collections.Generic;
using System.Text;

namespace UseListForCS4
{
    public class B
    {
        public int i = 0;
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
            Console.WriteLine("生成一个类型为B的List集合并以随机填充其内容：");
            List<B> BList = new List<B>();
            B tempB = null;
            //加入元素
            for (int i = 0; i < 10; i++)
            {
                tempB = new B();
                tempB.i = ran.Next(0, 100); //使用0～100间的随机数
                BList.Add(tempB);
            }

            foreach (B element in BList)
            {
                Console.Write("{0},", element.i);
            }

            //外挂一个对象比较器
            BList.Sort(Compare);

            //输出全部元素
            Console.WriteLine("\n类型为B的List集合排序后的结果：");

            foreach (B element in BList)
            {
                Console.Write("{0},", element.i);
            }
            Console.ReadKey();
        }
        //比较两个B类型对象的大小
        static int Compare(B one, B two)
        {
            if (one.i > two.i)
                return 1;
            if (one.i == two.i)
                return 0;
            return -1;
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
