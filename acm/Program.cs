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
            string a = "9223372039223372039223372036854792233720392233720392233720375808.992233720392922337203922337203922337203922337203922337203233720392233720392233720392233720392233720322337203";
            string b = "9223372092233720392233720336854922337203922337203922337203775808.922337203922337922337203922337203203922337203922337203922337203922337203922337203922337203922337203922337203";
            char[] aa = acm.Sum(a.ToCharArray(), b.ToCharArray());

            for (int i = aa.Count()-1; i >=0; i--)
            {
                Console.Write(aa[i]);
            }
           
        } 
    }
}
