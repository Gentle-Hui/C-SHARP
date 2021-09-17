using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience09125
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int b = int.Parse(Console.ReadLine());
            int Max = Program.WhitchMax(a, b);
            Console.WriteLine("更大的数字是{0}",Max);
            Console.ReadKey();
        }
        public static int WhitchMax(int n, int m)
        {
            return n > m ? n : m;

        }
    }
}
