using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 23;
            double n2 = 45;
            //希望让两个数字颠倒，则需要让n1=45，让n2=23.
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
            Console.WriteLine("交换后n1的值是{0}，n2的值是{1}。",n1,n2);
            Console.ReadKey();




        }
    }
}
