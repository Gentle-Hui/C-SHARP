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
        static string[] PlayersName = new string[2];
        //使用静态数组给玩家套上标记
        static bool[] Flags = new bool[2];//布尔数组内默认为0
        static void Main(string[] args)
        {
            GameHead();
            #region 输入玩家姓名
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请输入玩家A的姓名：");
            PlayersName[0] = Console.ReadLine();
            while (PlayersName[0] == "")
            {
                Console.WriteLine("输入的的姓名不能为空！");
            }
            Console.WriteLine("请输入玩家B的姓名：");
            PlayersName[1] = Console.ReadLine();
            while (PlayersName[1] == "" || PlayersName[0] == PlayersName[1])
            {
                if (PlayersName[1] == "")
                {
                    Console.WriteLine("输入的姓名不能为空！");
                    PlayersName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("输入的姓名已重复！");
                    PlayersName[1] = Console.ReadLine();
                }
            }
            #endregion
            //输入姓名之后要清屏一次然后重新调用游戏
            Console.Clear();
            GameHead();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}的士兵用A表示", PlayersName[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayersName[1]);
            InitiallMap();
            DrawMap();
            //当玩家A和B都没有在终点时，两个玩家可以不停的玩游戏
            #region 游戏过程
            while (PlayersSite[0] < 99 && PlayersSite[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if(PlayersSite[0]>=99){
                    Console.WriteLine("{0}无耻的赢了{1}",PlayersName[0],PlayersName[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayersSite[1] >= 99)
                {
                    Console.WriteLine("{0}无耻的赢了{1}", PlayersName[1], PlayersName[0]);
                    break;
                }
            }
            #endregion

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
            Console.WriteLine("图例：普通关卡□   幸运轮盘◎   地雷☆   暂停〓   时空隧道卍  ");
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
            for (int i = 64; i >= 35; i--)
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
                Console.ForegroundColor = ConsoleColor.White; a = "<>";
            }
            else if (PlayersSite[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.White; a = "Ａ";
            }
            else if (PlayersSite[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.White; a = "Ｂ";
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

        //玩游戏
        public static void PlayGame(int PlayersNumber)
        {
            Console.WriteLine("{0}按下任意键开始掷色子", PlayersName[PlayersNumber]);
            Console.ReadKey(true);
            Random Dise = new Random();
            int DiseNumber = Dise.Next(1, 7);
            //  int DiseNumber = 4;//调试用
            Console.WriteLine("{0}掷出了{1}", PlayersName[PlayersNumber], DiseNumber);
            PlayersSite[PlayersNumber] += DiseNumber;
            Console.ReadKey(true);
            Console.WriteLine("{0}按下任意键开始行动", PlayersName[PlayersNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayersName[PlayersNumber]);
            Console.ReadKey(true);
            if (PlayersSite[PlayersNumber] == PlayersSite[1 - PlayersNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退后六格", PlayersName[PlayersNumber], PlayersName[1 - PlayersNumber], PlayersName[1 - PlayersNumber]);
                PlayersSite[1 - PlayersNumber] -= 6;
                Console.ReadKey(true);

            }
            else
            {
                switch (Maps[PlayersSite[PlayersNumber]])
                {
                    case 0: Console.WriteLine("{0}踩到了方块，安全。", PlayersName[PlayersNumber]); Console.ReadKey(true);
                        break;
                    case 1: Console.WriteLine("{0}踩到了幸运轮盘，请选择1--交换对方位置，2--轰炸对方", PlayersName[PlayersNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择和玩家{1}交换位置", PlayersName[PlayersNumber], PlayersName[1 - PlayersNumber]);
                                Console.ReadKey(true);
                                int temp = PlayersSite[PlayersNumber];
                                PlayersSite[PlayersNumber] = PlayersSite[1 - PlayersNumber];
                                PlayersSite[1 - PlayersNumber] = temp;
                                Console.WriteLine("交换完成！按下任意键继续游戏。");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}", PlayersName[PlayersNumber], PlayersName[1 - PlayersNumber]);
                                Console.ReadKey(true);
                                PlayersSite[1 - PlayersNumber] -= 6;
                                Console.WriteLine("BOOM!!!  轰炸完成，按下任意键继续游戏。");
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或2  1--交换位置  2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2: Console.WriteLine("BOOM!!!   {0}踩到了地雷，后退六格", PlayersName[PlayersNumber]);
                        Console.ReadKey(true);
                        PlayersSite[PlayersNumber] -= 6;
                        break;
                    case 3: Console.WriteLine("{0}踩到了暂停，暂停一回合", PlayersName[PlayersNumber]);
                        Flags[PlayersNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4: Console.WriteLine("{0}踩到了时空隧道，前进十格", PlayersName[PlayersNumber]);
                        PlayersSite[PlayersNumber] += 10;
                        Console.ReadKey(true);
                        break;
                }
            }
            ChangeSite();
            Console.Clear();
            DrawMap();

        }

        //坐标变化时的限制
        public static void ChangeSite()
        {
            if (PlayersSite[0] < 0)
            {
                PlayersSite[0] = 0;
            }
            if (PlayersSite[0] >= 99)
            {
                PlayersSite[0] = 99;
            }
            if (PlayersSite[1] < 0)
            {
                PlayersSite[1] = 0;
            }
            if (PlayersSite[1] >= 99)
            {
                PlayersSite[1] = 99;
            }
        }
    }
}
