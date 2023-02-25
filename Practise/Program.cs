using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        public static class sum
        {
            public static int staticvar = 5;
            public static void call()
            {
                Console.WriteLine("Inside static method");
            }
        }
        static void Main(string[] args)
        {

            Console.Write("Call is :", sum.staticvar);
            sum.call();
            Console.ReadLine();
        }
    }
}
