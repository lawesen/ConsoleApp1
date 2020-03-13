using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public double a, b;
        public double TestName()
        {
            return a * b;
        }
        public void Display()
        {
            Console.WriteLine("a的值是：{0}", a);
            Console.WriteLine("b的值是：{0}", b);
            Console.WriteLine("a*b的值是：{0}", TestName());
        }
    }
}
