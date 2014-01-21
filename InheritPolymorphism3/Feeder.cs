using System;
using System.Collections.Generic;
using System.Text;

namespace InheritPolymorphism
{
    //动物园饲养员
    class Feeder
    {
        public String Name;

        public void FeedAnimal(Animal animals)
        {
            animals.eat();
        }

        //喂养一群动物
        public void FeedAnimals(Animal[] ans)
        {
            foreach (Animal an in ans)
            {
                an.eat();
            }
        }
     }
}
