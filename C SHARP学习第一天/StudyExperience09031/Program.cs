using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExperience09031
{
    class Program
    {
        static void Main(string[] args)
        {
            int English = 89;
            int Chinese = 92;
            int Math = 99;
            Console.WriteLine("该学生的总成绩为{0}，平均成绩为{1}.",English+Chinese+Math,(English+Chinese+Math)/3);
            Console.ReadKey();

        }
    }
}
