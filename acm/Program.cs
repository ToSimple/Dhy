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
            string a = "999999999999";
            string b = "1";
            char[] aa = acm.Sum(a.ToCharArray(), b.ToCharArray());
            Console.WriteLine(a.Length);
            Console.WriteLine(aa.Count());
            for (int i = 0; i < aa.Count(); i++)
            {

                Console.Write(aa[i]);

            }
           
        }
    }
}
