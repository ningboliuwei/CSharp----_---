using System;
using System.Collections.Generic;
using System.Text;

namespace InheritPolymorphism2
{
   

        //����԰����Ա
        class Feeder
        {
            public String Name;
            
            public void FeedAnimal(Animal animals)
            {
                animals.eat();
            }
        }

    
}
