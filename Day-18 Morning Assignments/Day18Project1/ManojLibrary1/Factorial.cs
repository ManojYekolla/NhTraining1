﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManojLibrary1;

namespace ManojLibrary1
{
    public static class Factorial
    {
        public static int Algebra(int n)
        {
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return - 999;
            else
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                    fact = fact * i;

                    
            }
            

            return 0;

        }

    }
}
