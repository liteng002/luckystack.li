using System;

namespace CSharpL
{
    class Program
    {
        private static string liteng = "liteng";
        private static int strAge;
        private static object calendar;

        static void Main(string[] args)
        {


            ///http://17bang.ren/Article/438
            ///1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9


            //for (int one = 1; one <= 5; one++)
            //{
            //    Console.WriteLine(one);
            //}

            //int two = 1;
            //while (two <= 5)
            //{
            //    Console.WriteLine(two);
            //    two++;
            //}

            //for (int three = 1; three <= 9; three += 2)
            //{
            //    Console.WriteLine(three);
            //}

            //int four = 1;
            //while (four <= 9)
            //{
            //    Console.WriteLine(four);
            //    four += 2;
            //}

            #region MyRegion
            //2.用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称

            //string[] five = new string[] { "李腾", "刘江平", "王明志", "阿泰", "黄蔓杰", "赵淼" };
            //Console.WriteLine(five[2]);
            //for (int i = 0; i < five.Length; i++)
            //{
            //    Console.WriteLine(five[i]);
            //}

            //string[,] six = { { "李腾", "刘江平", "王明志", "阿泰", "黄蔓杰", "赵淼" },
            //                   { "陌城", "川有", "王月", "阿泰", "bili", "推理" }, };


            //for (int i = 0; i < six.GetLength(1); i++)
            //{
            //    Console.WriteLine($"{six[0, i]}在直播间的名字叫{six[1, i]}");
            //}




            #endregion


            #region MyRegion
            //3.让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值

            //int figure = 0;
            //for (int i = 1; i <= 99; i += 2)
            //{
            //    figure += i;
            //}
            //Console.WriteLine(figure);
            #endregion

            #region MyRegion
            ////4.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] grade = { 99, 60, 78, 31, 8, 82 };
            //double max = grade[0];
            //double min = grade[0];
            //for (int i = 0; i < grade.Length; i++)
            //{
            //    if (min > grade[i])
            //    {
            //        min = grade[i];
            //        if (max < grade[i])
            //        {
            //            max = grade[i];
            //        }
            //        else
            //        {
            //            // nothing
            //        }
            //    }
            //    else
            //    {
            //        // nothing
            //    }
            //}
            //Console.WriteLine($"{max},{min}");





            #endregion

            #region MyRegion
            //5.找到100以内的所有质数（只能被1和它自己整除的数）
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 != 0 && i < 9)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        else
            //        {
            //            //nothing
            //        }
            //    }
            //}

            #endregion



            #region MyRegion
            //6.生成一个元素（值随机）从小到大排列的数组
            //int[] order = new int[10];
            //for (int i = 0; i < order.Length; i++)
            //{
            //    order[i] = new Random().Next(1000);
            //}
            //Console.WriteLine(order);





            #endregion
            ////总价
            //int i = 898;
            //int j = 88;
            //Console.WriteLine(i+j);
            ////学费
            //int k = 986;           
            //Console.WriteLine(k-j);
            ////一天的学费
            //float t = 5;
            //Console.WriteLine(i/t);
            ////五天的学费
            //double o = 179.6;
            //Console.WriteLine(o*t);


            ////小数点两位没做出来
            //int fee = 23;
            //byte fxx = 7;
            //int faa = 12;
            //byte fcc = 8;
            //decimal fgg = 6.00m;
            //Console.WriteLine(((fee+fxx)*faa-fcc)/fgg);



            ////a=10
            //int a = 10;
            //bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
            //Console.WriteLine((a + 3 > 12) && a < 3.14 * 4 && a != 11);







            //Console.WriteLine("请输入验证码（0025）");
            //int a = Convert.ToInt32(Console.ReadLine());           //用户输入
            //if (0025 == a)                                         //有点懵逼，重做一次
            //{                                                      //
            //    Console.WriteLine("请输入用户名(liteng）");
            //    string b = Console.ReadLine();
            //    if (liteng == b)
            //    {
            //        Console.WriteLine("请输入密码(1234）");
            //        int c = Convert.ToInt32(Console.ReadLine());
            //        if (1234 == c)
            //        {
            //            Console.WriteLine("恭喜！登录成功");
            //        }
            //        else
            //        {
            //            Console.WriteLine("用户名或密码错误");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("验证码错误");
            //}


            //Console.WriteLine("请输入验证码（0025）");               //全部都是字符串
            //string a = Console.ReadLine();
            //if ("0025" == a)
            //{
            //    Console.WriteLine("请输入用户名（liteng）");
            //    string b = Console.ReadLine();
            //    if ("liteng" == b)
            //    {
            //        Console.WriteLine("请输入密码（1234）");
            //        string c = Console.ReadLine();
            //        if ("1234" == c)
            //        {
            //            Console.WriteLine("恭喜！登录成功！");

            //        }
            //        else
            //        {
            //            Console.WriteLine("用户名或者密码错误");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("验证码错误");
            //}

            ////星期
            //int[] week = new int[7];
            //week[0] = 1;
            //week[1] = 2;
            //week[2] = 3;
            //week[3] = 4;
            //week[4] = 5;
            //week[5] = 6;
            //week[6] = 7;
            //for (int i = 0; i < week.Length; i++)
            //{
            //    Console.WriteLine(week[i]);
            //}


            //int[] week = new int[] { 1,2,3,4,5,6,7};
            //Console.WriteLine(week[0+2]);

            //string[] week = new string[] { "1", "2", "3", "4", "5", "6", "7", };
            //Console.WriteLine(week[0]);
            //for (int i = 0; i < week.Length; i++)
            //{
            //    Console.WriteLine(week[i]);
            //}


            //int[,] calendar = new int[4, 7];
            //calendar[0, 0] = 1;
            //calendar[0, 1] = 2;
            //calendar[0, 2] = 3;
            //calendar[0, 3] = 4;
            //calendar[0, 4] = 5;
            //calendar[0, 5] = 6;
            //calendar[0, 6] = 7;
            //calendar[1, 0] = 8;
            //calendar[1, 1] = 9;
            //calendar[1, 2] = 10;
            //calendar[1, 3] = 11;
            //calendar[1, 4] = 12;
            //calendar[1, 5] = 13;
            //calendar[1, 6] = 14;
            //calendar[2, 0] = 15;
            //calendar[2, 1] = 16;
            //calendar[2, 2] = 17;
            //calendar[2, 3] = 18;
            //calendar[2, 4] = 19;
            //calendar[2, 5] = 20;
            //calendar[2, 6] = 21;
            //calendar[3, 0] = 22;
            //calendar[3, 1] = 23;
            //calendar[3, 2] = 24;
            //calendar[3, 3] = 25;
            //calendar[3, 4] = 26;
            //calendar[3, 5] = 27;
            //calendar[3, 6] = 28;
            //Console.WriteLine(calendar.Length);
            //Console.WriteLine(calendar.Rank);
            //Console.WriteLine(calendar.GetLength(1));
            //Console.WriteLine(value: calendar[3, 0]);






            //int[,] calendar = { { 1, 2, 3, 4, 5, 6, 7, }, { 8, 9, 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19, 20, 21 }, { 22, 23, 24, 25, 26, 27, 28 } };
            ////Console.WriteLine(calendar.Length);
            ////Console.WriteLine(calendar.Rank);
            ////Console.WriteLine(calendar.GetLength(1));

            //for (int i = 0; i < calendar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < calendar.GetLength(1); j++)
            //    {
            //        Console.Write(calendar[i, j]+", ");
            //    }
            //}




        }
    }
}
