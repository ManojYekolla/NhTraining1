using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManojLibrary1
{
    public class ParentClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;

        public void MyParentClass()
        {
            a = 3;
            b = 4;
            c = 5;
            d = 6;
            e = 7;
        }
    }
    public class ChildClass : ParentClass
    {
        public void MyChildClass()
        {
             a = 3;
             b = 4;
             c = 5;
             d = 6;
             e = 7;
        }
    }
    public class OtherClass
    {
        public void MyOtherClass()
        {
            ParentClass obj = new ParentClass();

             obj.a = 3;
             obj.b = 4;
             obj.c = 5;
             obj.d = 6;
             obj.e = 7;
        }
    }
}


