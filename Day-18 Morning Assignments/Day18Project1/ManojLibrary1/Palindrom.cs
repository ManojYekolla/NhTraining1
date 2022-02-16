using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManojLibrary1
{
    public class Palindrom
    {
        public static int Algebra(int n)
        {
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -999;
            else
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;

            }
        }
            

            public static bool IsAlgebra(int n)
            {
                int rev = 0, rem, t;
                t = n;
                while (t > 0)
                {
                    rem = t % 10;
                    t= t / 10;
                    rev = rev * 10 + rem;

                }
                if(n==rev)
                    return true;
                else
                    return false;   
            }

    }
}
