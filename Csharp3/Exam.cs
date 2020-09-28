using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3
{
    class Exam
    {
        private int phy, che;

        public int physics
        {
            get
            {
                Console.WriteLine("get phy value");
                return phy;
            }
            set
            {
                if(value >= 0 && value <= 150)
                {
                    phy = value;
                } else
                {
                    Console.WriteLine("Invalid physics marks.");
                }
            }
        }

        public int chemistry
        {
            get
            {
                Console.WriteLine("get che value");
                return che;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    che = value;
                } else
                {
                    Console.WriteLine("invalid chemistry mark");
                }
            }
        }
    }
}
