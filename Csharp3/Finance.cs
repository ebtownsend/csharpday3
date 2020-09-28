using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3
{
    class Finance
    {
        public int Tax()
        {
            return 30;
        }

        public float Tax(int salary)
        {
            float t = (float)salary  * Tax() / 100;
            return t;
        }

        public float Tax(int salary, int t1)
        {
            float myTax = salary * t1 / 100;
            return myTax;
        }
    }
}
