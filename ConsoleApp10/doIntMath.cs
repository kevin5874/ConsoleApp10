using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class doIntMath
    {
        public int addMath(int x)
        {
            x += 3;
            return x;
        }
        public int minusMath(int x)
        {
            x -= 3;
            return x;
        }
        public int DivideMath(int x)
        {
            x /= 2; // since we're using ints as parameter and return type this is going to return just the integer portion of the math operation
            // for instance 3 /= 2 == 1 instead of 1.5
            return x;
        }
    }
}
