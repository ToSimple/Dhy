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

            foreach (var item in acm.exponentiation("13.132", 100))
            {
                Console.Write(item);
            }
        }
    }
}
