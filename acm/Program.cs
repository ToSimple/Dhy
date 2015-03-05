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
            string s = "12312312";
            Console.WriteLine( acm.Chen(s.ToCharArray(), '2'));
        }
    }
}
