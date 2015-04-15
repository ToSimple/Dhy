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

            //float[,] a = new float[2,2];
            //a[0, 0] = 1.0f;
            //a[0, 1] = 1.0f;
            //a[1, 0] = 25.0f;
            //a[1, 1] = 0.0f;

            //acm.acm1005(2,a);

            //acm.acm1006(5, 20, 34, 325);
            //acm.acm1006(4, 5, 6, 7);
            //acm.acm1006(283, 102, 23, 320);
            //acm.acm1006(203, 301, 203, 40);

            //string[] n = new string[6];
            //n[0] = "AACATGAAGG";
            //n[1] = "TTTTGGCCAA";
            //n[2] = "TTTGGCCAAA";
            //n[3] = "GATCAGATTT";
            //n[4] = "CCCGGGGGGA";
            //n[5] = "ATCGATGCAT";
            //acm.acm1007(6, n);

            //acm.Acm1008(10, "zac", 0);
            //acm.Acm1008(0, "pop", 0);
            //acm.Acm1008(10, "zac", 1995);

            //int[] a = new int[] { 100, 150, 80, 120, 155, 100, 120 };
            //int[] b = new int[] { 25, 35, 25, 80, 40, 100, 110 };
            //acm.Acm1018(a, b);


           List<a> items = new List<a>();
           items.Add(new a { Id = 1, Name = "小米", ComeDate = DateTime.Now, Year="一年级" });
           items.Add(new a { Id = 2, Name = "小明", ComeDate = DateTime.Now.AddDays(2), Year = "一年级" });
           items.Add(new a { Id = 3, Name = "小王", ComeDate = DateTime.Now.AddDays(1), Year = "一年级" });

           List<a> items2 = new List<a>();
           items2.Add(new a { Id = 1, Name = "小米", ComeDate = DateTime.Now, Year = "一年级" });
           items2.Add(new a { Id = 2, Name = "小明", ComeDate = DateTime.Now.AddDays(2), Year = "二年级" });
           items2.Add(new a { Id = 3, Name = "小王", ComeDate = DateTime.Now.AddDays(1), Year = "二年级" });

           List<a> items3 = new List<a>();
           items3.Add(new a { Id = 1, Name = "小米", ComeDate = DateTime.Now, Year = "一年级" });
           items3.Add(new a { Id = 2, Name = "小明", ComeDate = DateTime.Now.AddDays(2), Year = "二年级" });
           items3.Add(new a { Id = 3, Name = "小王", ComeDate = DateTime.Now.AddDays(1), Year = "三年级" });

           foreach (var i in items2.GroupBy(c => c.Year).Select(d => new { d.Key, Value = d.OrderByDescending(c => c.ComeDate).ToList() }))
           {
              
               Console.WriteLine("Key="+ i.Key);
               Console.WriteLine("Vale:");
               foreach (var j in i.Value)
               {
                   Console.WriteLine("年纪"+j.Year);
                   Console.WriteLine("学号="+j.Id);
                   Console.WriteLine("姓名="+j.Name);
                   Console.WriteLine("入学时间=" + j.ComeDate);
               }
             
           }
           

        }
        public class a
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime ComeDate { get; set; }
            public string Year { get; set; }
        }
    }
}
