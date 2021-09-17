using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0916飞行棋
{
    class Program
    {
        //保存地图的数组-用静态字段模拟全局变量
        static int[] Maps = new int[100];
        //使用静态数组保存玩家AandB的坐标
        static int[] PlayersSite = new int[2];
        //使用静态数组保存玩家姓名
        static string[] PlayersName=new string[2];
        static void Main(string[] args)
        {
            GameHead();
            Console.WriteLine("请输入玩家A的姓名：");
            PlayersName[0]=Console.ReadLine();
            while(PlayersName[0]==""){
                Console.WriteLine("输入的的姓名不能为空！");
            }
            Console.WriteLine("请输入玩家B的姓名：");
            PlayersName[1] = Console.ReadLine();
            while(PlayersName[1]==""||PlayersName[0]==PlayersName[1]){
                if (PlayersName[1] == "")
                {
                    Console.WriteLine("输入的姓名不能为空！");
                }
                else {
                    Console.WriteLine("输入的姓名已重复！");
                }
            }
            InitiallMap();
            DrawMap();
            Console.ReadKey();
        }

        //游戏头
        public static void GameHead()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************飞行棋***********");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*****************************");
        }

        //初始地图
        public static void InitiallMap()
        {
            //飞行棋地图中包括五种关卡，普通，幸运轮盘，地雷，暂停，时空隧道
            //在地图数组中，元素为0是普通关卡，幸运轮盘是1，地雷是2，暂停是3，时空隧道是4
            int[] LuckyRoulette = { 6, 23, 40, 55, 69, 83 };//幸运轮盘
            for (int i = 0; i < LuckyRoulette.Length; i++) { int index = LuckyRoulette[i]; Maps[index] = 1; }
            int[] Landmine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷
            for (int i = 0; i < Landmine.Length; i++) { int index = Landmine[i]; Maps[index] = 2; }
            int[] Pause = { 9, 27, 60, 93 };//暂停
            for (int i = 0; i < Pause.Length; i++) { int index = Pause[i]; Maps[index] = 3; }
            int[] Timetunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道
            for (int i = 0; i < Timetunnel.Length; i++) { int index = Timetunnel[i]; Maps[index] = 4; }

        }

        //绘制地图
        public static void DrawMap()
        {
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawPass(i));
            }
            Console.WriteLine();
            #endregion
            #region 第一竖列
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(DrawPass(i));
            }
            #endregion
            #region 第二横排
            for (int i = 35; i < 65; i++)
            {
                Console.Write(DrawPass(i));
            }
            Console.WriteLine();
            #endregion
            #region 第二竖列
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(DrawPass(i));
            }
            #endregion
            #region 第三横排
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawPass(i));
            }
            Console.WriteLine();
            #endregion
        }


        //绘制关卡
        public static string DrawPass(int i)
        {
            string a = "";
            if (PlayersSite[0] == PlayersSite[1] && PlayersSite[1] == i)
            {
                a = "<>";
            }
            else if (PlayersSite[0] == i)
            {
                a = "Ａ";
            }
            else if (PlayersSite[1] == i)
            {
                a = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0: Console.ForegroundColor = ConsoleColor.Yellow; a = "□";
                        break;
                    case 1: Console.ForegroundColor = ConsoleColor.Blue; a = "◎";
                        break;
                    case 2: Console.ForegroundColor = ConsoleColor.Red; a = "☆";
                        break;
                    case 3: Console.ForegroundColor = ConsoleColor.DarkGray; a = "〓";
                        break;
                    case 4: Console.ForegroundColor = ConsoleColor.Magenta; a = "卍";
                        break;
                }
            }
            return a;
        }
    }
}
