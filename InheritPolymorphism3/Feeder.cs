using System;
using System.Collections.Generic;
using System.Text;

namespace InheritPolymorphism
{
    //����԰����Ա
    class Feeder
    {
        public String Name;

        public void FeedAnimal(Animal animals)
        {
            animals.eat();
        }

        //ι��һȺ����
        public void FeedAnimals(Animal[] ans)
        {
            foreach (Animal an in ans)
            {
                an.eat();
            }
        }
     }
}
