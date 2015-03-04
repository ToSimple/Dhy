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

        public string Exp_Ext(double a, double b)
        {
            string c = a.ToString();

            for (int i = 0; i < c.Length; i++)
            {
                double d = Sum(c[i], c[i]);
                string e = d.ToString();
                if (e.Length > 1)
                {
                    if (c[i + 1] == 9)
                    {

                    }
                }
            }

            double sum = 1;
            while (b > 0)
            {
                sum *= a;
                b--;
            }
            return "";
        }
        public void a(string c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                double a = Sum(c[i], c[i]);
                
            }

        }
        public void b(double a,string c,int i)
        {
            if (a>9)
            {
               int b = Convert.ToInt32(c[i+1]) + 1;
                
            }

        }


    }
}
