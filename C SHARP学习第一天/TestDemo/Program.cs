using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //折叠

            //Console.WriteLine("Hello World!");//输出打印的内容
            //Console.ReadKey();//暂停代码
            //Console.WriteLine("Hello Mr.Wen!");
            //Console.ReadKey();



            #endregion

            #region
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
            #endregion
        }
    }

    class Rectangle {
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;    
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }


    }

