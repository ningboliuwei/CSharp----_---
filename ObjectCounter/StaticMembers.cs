using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCounter
{
    class StaticMembers
    {
        public static int staticVar=0;   //¾²Ì¬×Ö¶Î
        public int dynamicVar=0;    //ÊµÀý×Ö¶Î
        public void increaseValue()
        {
            staticVar++;
            dynamicVar++;
        }
    }
}
