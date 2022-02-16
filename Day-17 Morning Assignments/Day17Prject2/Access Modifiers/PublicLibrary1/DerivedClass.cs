using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManojLibrary1;

namespace PublicLibrary1
{
    public class DerivedClass :ParentClass
    {
        public void Myderivedclass()
        {
            a = 3;
            b = 4;
            c = 5;
            d = 6;
            e = 7;
        }

    }

    public class Otherclass1
    {

        public void MyOther()
        {
            ParentClass obj = new ParentClass();
           obj. a = 3;
           obj. b = 4;
           obj. c = 5;
           obj. d = 6;
            obj.e = 7;
        }
    }
}
