using System;
using System.Collections.Generic;
using System.Text;

namespace InheritPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //动物数组
            Animal[] ans={new Monkey(),new Pigeon(),new Lion()};

            Feeder f = new Feeder();
            f.Name = "小李";

            f.FeedAnimals(ans);

            Console.ReadKey();
        }
    }
}
