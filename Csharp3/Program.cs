using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            shop tesco = new shop();
            tesco.details(93, 125);

            Exam e = new Exam();
            e.physics = 30;
            e.chemistry = 20;
            Console.WriteLine(e.physics);
            Console.WriteLine(e.chemistry);

            char grade = 'A';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("You got an A");
                    break;
                case 'B':
                    Console.WriteLine("You got a B");
                    break;
                case 'C':
                    Console.WriteLine("You got a C");
                    break;
            }

            int[] salaries = { 1000, 2000, 500, 450 };
            int total = 0;

            for (int i = 0; i < salaries.Length; i++)
            {
                total += salaries[i];
            }
            Console.WriteLine(total);

            Console.Read();
        }
    }
}
