using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the Number from 1 to 100;
            //for (int i = 1; i<=100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //Reverse the string
            string str = " ", reverse = " ";
            Console.WriteLine("Please Entre the string");
            str = Console.ReadLine();
            int Lenght;
            Lenght = str.Length - 1;
            while(Lenght >= 0)
            {
                reverse = reverse + str[Lenght];
                Lenght--;
            }
            Console.WriteLine("Reverse string is : {0}", reverse);
            Console.ReadLine();
        }
    }
}
