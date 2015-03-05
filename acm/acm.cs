using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace acm
{
    public class acm
    {
        public static void acm1000()
        {
            Console.Write("请输入a：");
            string a = Console.ReadLine();
            Console.Write("请输入b：");
            string b = Console.ReadLine();
            Console.WriteLine(Sum(a, b));
        }
        public static void acm1001()
        {
            string a = "";
            string b = "";
            Console.Write("请输入R：");
            a = Console.ReadLine();
            Console.Write("请输入N：");
            b = Console.ReadLine();
            Console.WriteLine(Exp(a, b));

        }


        public static double Sum(char a, char b)
        {
            return Sum(Convert.ToDouble(a), Convert.ToDouble(b));
        }
        public static double Sum(string a, string b)
        {
            return Sum(Convert.ToDouble(a), Convert.ToDouble(b));
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// 求幂
        /// </summary>
        /// <param name="a">实数</param>
        /// <param name="b">b次方</param>
        /// <returns></returns>
        public static double Exp(string a, string b)
        {
            return Exp(Convert.ToDouble(a), Convert.ToDouble(b));
        }
        public static double Exp(double a, double b)
        {
            double sum = 1;
            while (b > 0)
            {
                sum *= a;
                b--;
            }
            return sum;
        }

        /// <summary>
        /// 求高精度幂
        /// </summary>
        /// <param name="a">实数</param>
        /// <param name="b">b次方</param>
        /// <param name="c">精度位数</param>
        /// <returns></returns>
        public static string Exp(string a, string b, int c = 9999)
        {
            char[] result = new char[c];
            char[] cc = a.ToCharArray();//实数转char 放入数组
            foreach (var item in cc)
            {
                Console.WriteLine((int)item - 48);
            }

            do
            {
                c--;
            } while (c > 0);

            string s = new string(cc);

            //string shishu = a.ToString();
            //int sum = shishu.Length;
            //int jssum = 0;
            //foreach (var item in shishu)
            //{
            //    if (jssum<c)
            //    {
            //        j[0] = item;
            //        jssum++;
            //    }

            //}
            Console.WriteLine(s);
            return s;



            //for (int i = 0; i < c.Length; i++)
            //{
            //    double d = Sum(c[i], c[i]);
            //    string e = d.ToString();
            //    if (e.Length > 1)
            //    {

            //    }
            //    else
            //    {
            //        c[i] = Convert.ToChar(e);
            //    }
            //}

            //double sum = 1;
            //while (b > 0)
            //{
            //    sum *= a;
            //    b--;
            //}
            //return "";
        }






        public static int chen(char[] a, char[] b)
        {
            List<char[]> items = new List<char[]>();
            
            return 0;
        }

        /// <summary>
        /// 计算 多(8位以内) 乘 一 ，包括位数
        /// </summary>
        /// <param name="a">多</param>
        /// <param name="b">一</param>
        /// <param name="c">位数</param>
        /// <returns></returns>
        public static int Chen(char[] a, char b)
        {
            int sum = 0;
            int j = a.Count()-1;
            for (int i = 0; i < a.Count(); i++)
            {
                sum += Chen(a[i], b) * TenCiFang(j);
                j--;
            }
            return sum;
        }
        private static int Chen(char a, char b)
        {
            int c = ((int)a - 48) * ((int)b - 48);
            return c;
        }
        private static int TenCiFang(int a)
        {
            int re = 1;
            for (int i = 1; i <= a; i++)
            {
                re *= 10;
            }
            return re;
        }

    }
}
