using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCounter
{
    class StaticMembers
    {
        public static int staticVar=0;   //��̬�ֶ�
        public int dynamicVar=0;    //ʵ���ֶ�
        public void increaseValue()
        {
            staticVar++;
            dynamicVar++;
        }
    }
}
