using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTest2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Test test = new Test();
            Console.WriteLine("enter a first  number: ");
            test.a = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("enter a second  number: ");
            test.b = Convert.ToInt32(Console.ReadLine());
            test.AddTwoNumber(test.a, test.b);

        }
    }
}
