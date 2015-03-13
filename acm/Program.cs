using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace acm
{
    class Program
    {
        static void Main(string[] args)
        {
            //acm.acm1000();
            // acm.acm1001();
            //acm.Exp("12", "2", 0);
            //acm.Chen('8', '2');
            //string s = "99999999";
            //Console.WriteLine( acm.Chen(s.ToCharArray(), '9'));
            //string a = "18312312333720123123333922337203775808.992233720392922337203922337203922337203922337203922337203233720392233720392233720392233720392233720322337203";
            //string b = "9223372092233720392233720336854922337203922337203922337203775808.31231233311";
            //char[] aa = acm.Sum(a.ToCharArray(), b.ToCharArray());

            //for (int i = aa.Count()-1; i >=0; i--)
            //{
            //    Console.Write(aa[i]);
            //}


            //string a = "199";
            //string b = "1";
            //char[] aa = acm.SumF(a, b);
            //for (int i = aa.Count() - 1; i >= 0; i--)
            //{
            //    Console.Write(aa[i]);
            //}

            // string a = "123";
            //string b= "1233";
            //string a = "123";
            //string b = "11.123";
            //string b = "4";
            // string a = "3.1231234413";
            //char[] aa = acm.Diff(a, b);


            //string a = "43958234589324598345.534523450823094580349859034289508";
            //int b = 9;
            //char[] aa = acm.QuadUnit(a,b);

            //for (int i = aa.Count() - 1; i >= 0; i--)
            //{
            //    Console.Write(aa[i]);
            //}

            //char[] aa = new char[1];
            //string a = "88.08";
            //string b = "";
            //string c = "0.008";
            //for (int i = 0; i <1; i++)
            //{
            //    aa = acm.Quadrature(c, a);
            //    b = "";
            //    foreach (var item in aa)
            //    {
            //        b += item;
            //    }
            //    c = b;
            //}
            //Console.WriteLine(c);

            //foreach (var item in acm.exponentiation("13.132", 100))
            //{
            //    Console.Write(item);
            //}

            //string[] azx = new string[] { "12", "4873279", "ITS-EASY", "888-4567", "3-10-10-10", "888-GLOP", "TUT-GLOP", "967-11-11", "310-GINO", "F101010", "888-1200", "-4-8-7-3-2-7-9-", "487-3279", "14134134", "13121213", "4512333", "332211", "16612333", "133","1112" };
            //acm.acm1002(azx);

            //acm.acm1003(1.00);
            //acm.acm1003(3.71);
            //acm.acm1003(0.04);
            //acm.acm1003(5.19);
            //acm.acm1003(0.00);
            // float[] a = new float[] { 100.00f, 489.12f, 12454.12f, 1234.10f, 823.05f, 109.20f, 5.27f, 1542.25f, 839.18f, 83.99f, 1295.01f, 1.75f };
            //acm.acm1004(a);
            float[,] a = new float[2,2];
            a[0, 0] = 1.0f;
            a[0, 1] = 1.0f;
            a[1, 0] = 25.0f;
            a[1, 1] = 0.0f;

            acm.acm1005(2,a);
        }
    }
}
