using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        public interface Istudent
        {
            void putdata();
        }
        public class student : Istudent
        {
            public int rollnumber;
            public string name;
            public student(int r, string n)
            {
                rollnumber = r;
                name = n;
            }
            public void putdata()
            {
                Console.WriteLine("Student Roll number = {0}", rollnumber);
                Console.WriteLine("Student name is : {0}", name);

            }
        }

        static void Main(string[] args)
        {
            student s1 = new student(1,"pawan");
           
            s1.putdata();
            Console.ReadLine();

        }
    }
}
