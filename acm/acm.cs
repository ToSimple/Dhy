using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

        #region 实验的
        public static double Sum(char a, char b)
        {
            return Sum(Convert.ToDouble(a), Convert.ToDouble(b));
        }
        //public static double Sum(string a, string b)
        //{
        //    return Sum(Convert.ToDouble(a), Convert.ToDouble(b));
        //}
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
            #region 拆分大数
            List<char[]> items = new List<char[]>();
            if (a.Count() / 8 == 0)
            {

            }
            for (int i = 0; i < a.Count() / 8; i++)
            {
                items.Add(new char[8] { a[i + 1], a[i], a[i], a[i], a[i], a[i], a[i], a[i] });
            }
            #endregion

            int dot = 0;
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] == '.')
                {
                    dot = i;
                }
            }
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
            int j = a.Count() - 1;
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

        public static char[] Sum(string a, string b)
        {
            return Sum(a.ToCharArray(), b.ToCharArray());
        }
        public static char[] Sum(char[] a, char[] b)
        {
            char[] c = a;//补位后的a
            char[] d = b;//补位后的b
            int alength = a.Count();//a长度
            int blength = b.Count();//b长度
            int adot = alength;//a小数点位置
            int bdot = blength;//b小数点位置
            #region 小数点补位
            for (int i = 0; i < alength; i++)
            {
                if (a[i] == '.')
                {
                    adot = i;
                    break;
                }
            }
            for (int i = 0; i < blength; i++)
            {
                if (b[i] == '.')
                {
                    bdot = i;
                    break;
                }
            }
            if (adot != alength || bdot != blength)
            {
                if (adot == alength)
                {
                    c = new char[alength + 1 + blength - bdot - 1];
                    for (int i = 0; i < c.Length; i++)
                    {
                        if (i < alength)
                        {
                            c[i] = a[i];
                        }
                        else if (i == alength)
                        {
                            c[i] = '.';
                        }
                        else
                        {
                            c[i] = '0';
                        }
                    }

                }
                else if (bdot == blength)
                {
                    d = new char[blength + 1 + alength - adot - 1];
                    for (int i = 0; i < d.Length; i++)
                    {
                        if (i < blength)
                        {
                            d[i] = b[i];
                        }
                        else if (i == blength)
                        {
                            d[i] = '.';
                        }
                        else
                        {
                            d[i] = '0';
                        }
                    }
                }
                else
                {
                    if (alength - adot > blength - bdot)
                    {
                        d = new char[blength + ((alength - adot) - (blength - bdot))];
                        for (int i = 0; i < d.Length; i++)
                        {
                            if (i < blength)
                            {
                                d[i] = b[i];
                            }
                            else
                            {
                                d[i] = '0';
                            }
                        }
                    }
                    else
                    {
                        c = new char[alength + ((blength - bdot) - (alength - adot))];
                        for (int i = 0; i < c.Length; i++)
                        {
                            if (i < alength)
                            {
                                c[i] = a[i];
                            }
                            else
                            {
                                c[i] = '0';
                            }
                        }
                    }
                }
            }

            #endregion

            List<char> item = new List<char>();
            int cl = c.Length;
            int dl = d.Length;
            int r = 0;
            int jw = 0;//进位
            do
            {
                if (cl > 0 && dl > 0)
                {
                    if (c[cl - 1] == '.')
                    {
                        r = '.';
                    }
                    else
                    {
                        r = (int)c[cl - 1] + (int)d[dl - 1] - 96 + jw;
                        jw = 0;
                        if (r >= 10)
                        {
                            jw++;
                            r = r - 10;
                        }
                    }
                }
                else if (cl <= 0 && dl > 0)
                {
                    r = d[dl - 1] - 48 + jw;
                    jw = 0;
                    if (r >= 10)
                    {
                        jw++;
                        r = r - 10;
                    }
                }
                else if (cl > 0 && dl <= 0)
                {
                    r = c[cl - 1] - 48 + jw;
                    jw = 0;
                    if (r >= 10)
                    {
                        jw++;
                        r = r - 10;
                    }
                }

                if (r == 46)
                {
                    item.Add(Convert.ToChar(r));
                }
                else
                {
                    item.Add(Convert.ToChar(r.ToString()));
                }
                cl--; dl--;
            } while (cl > 0 || dl > 0);
            if (jw == 1)
            {
                item.Add('1');
            }
            return item.ToArray();
        }

        #endregion
        #region 有用的
        public static void Buwei(char[] a, char[] b)
        {
            char[] c = a;//补位后的a
            char[] d = b;//补位后的b
            int alength = a.Count();//a长度
            int blength = b.Count();//b长度
            int adot = alength;//a小数点位置
            int bdot = blength;//b小数点位置

            for (int i = 0; i < alength; i++)
            {
                if (a[i] == '.')
                {
                    adot = i;
                    break;
                }
            }
            for (int i = 0; i < blength; i++)
            {
                if (b[i] == '.')
                {
                    bdot = i;
                    break;
                }
            }
            if (adot != alength || bdot != blength)
            {
                if (adot == alength)
                {
                    c = new char[alength + 1 + blength - bdot - 1];
                    for (int i = 0; i < c.Length; i++)
                    {
                        if (i < alength)
                        {
                            c[i] = a[i];
                        }
                        else if (i == alength)
                        {
                            c[i] = '.';
                        }
                        else
                        {
                            c[i] = '0';
                        }
                    }

                }
                else if (bdot == blength)
                {
                    d = new char[blength + 1 + alength - adot - 1];
                    for (int i = 0; i < d.Length; i++)
                    {
                        if (i < blength)
                        {
                            d[i] = b[i];
                        }
                        else if (i == blength)
                        {
                            d[i] = '.';
                        }
                        else
                        {
                            d[i] = '0';
                        }
                    }
                }
                else
                {
                    if (alength - adot > blength - bdot)
                    {
                        d = new char[blength + ((alength - adot) - (blength - bdot))];
                        for (int i = 0; i < d.Length; i++)
                        {
                            if (i < blength)
                            {
                                d[i] = b[i];
                            }
                            else
                            {
                                d[i] = '0';
                            }
                        }
                    }
                    else
                    {
                        c = new char[alength + ((blength - bdot) - (alength - adot))];
                        for (int i = 0; i < c.Length; i++)
                        {
                            if (i < alength)
                            {
                                c[i] = a[i];
                            }
                            else
                            {
                                c[i] = '0';
                            }
                        }
                    }
                }
            }
            a = c;
            b = d;
            //foreach (var item in a)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //foreach (var item in b)
            //{
            //    Console.Write(item);
            //}

        }
        public static void BuweiF(ref string a, ref string b)
        {
            int al = a.Length;
            int bl = b.Length;
            string[] c = a.Split('.');
            string[] d = b.Split('.');
            int i = al - c[0].Length;
            int j = bl - d[0].Length;
            if (i != 0 && j != 0)
            {
                if (i > j)
                {
                    while (i != j)
                    {
                        b += "0";
                        j++;
                    }
                }
                else
                {
                    while (i != j)
                    {
                        a += "0";
                        i++;
                    }
                }
            }
            else if (i != 0 && j == 0)
            {
                b += ".";
                j++;
                while (i != j)
                {
                    b += "0";
                    j++;
                }
            }
            else if (i == 0 && j != 0)
            {
                a += ".";
                i++;
                while (i != j)
                {
                    a += "0";
                    i++;
                }
            }
            //Console.WriteLine(a);
            // Console.WriteLine(b);
        }
        public static char[] SumF(string a, string b)
        {
            BuweiF(ref a, ref b);//小数点后补位
            List<char> item = new List<char>();
            List<char> ritems = new List<char>();
            int al = a.Length;
            int bl = b.Length;
            int r = 0;
            int jw = 0;//进位
            do
            {
                if (al > 0 && bl > 0)
                {
                    if (a[al - 1] == '.')
                    {
                        r = '.';
                    }
                    else
                    {
                        r = (int)a[al - 1] + (int)b[bl - 1] - 96 + jw;
                        jw = 0;
                        if (r >= 10)
                        {
                            jw++;
                            r = r - 10;
                        }
                    }
                }
                else if (al <= 0 && bl > 0)
                {
                    r = b[bl - 1] - 48 + jw;
                    jw = 0;
                    if (r >= 10)
                    {
                        jw++;
                        r = r - 10;
                    }
                }
                else if (al > 0 && bl <= 0)
                {
                    r = a[al - 1] - 48 + jw;
                    jw = 0;
                    if (r >= 10)
                    {
                        jw++;
                        r = r - 10;
                    }
                }

                if (r == 46)
                {
                    item.Add(Convert.ToChar(r));
                }
                else
                {
                    item.Add(Convert.ToChar(r.ToString()));
                }
                al--; bl--;
            } while (al > 0 || bl > 0);
            if (jw == 1)
            {
                item.Add('1');
            }
            for (int i = item.Count() - 1; i >= 0; i--)
            {
                ritems.Add(item[i]);
            }
            return ritems.ToArray();
        }
        public static char[] Diff(string a, string b)
        {
            BuweiF(ref a, ref b);
            List<char> item = new List<char>();
            int al = a.Length;
            int bl = b.Length;
            int r = 0;
            int jw = 0;//退位
            bool fushu = false;
            if (al > bl)
            {
                do
                {
                    if (al > 0 && bl > 0)
                    {
                        if (a[al - 1] == '.')
                        {
                            r = '.';
                        }
                        else
                        {
                            r = (int)a[al - 1] - (int)b[bl - 1] - jw;
                            jw = 0;
                            if (r < 0)
                            {
                                r = 10 + r;
                                jw++;
                            }
                        }
                    }
                    else if (al > 0 && bl <= 0)
                    {
                        r = a[al - 1] - 48 - jw;
                        jw = 0;
                        if (r < 0)
                        {
                            r = 10 + r;
                            jw++;
                        }
                    }

                    if (r == 46)
                    {
                        item.Add(Convert.ToChar(r));
                    }
                    else
                    {
                        item.Add(Convert.ToChar(r.ToString()));
                    }
                    al--; bl--;
                } while (al > 0 || bl > 0);
            }
            else if (al < bl)
            {
                fushu = true;
                do
                {
                    if (al > 0 && bl > 0)
                    {
                        if (b[bl - 1] == '.')
                        {
                            r = '.';
                        }
                        else
                        {
                            r = (int)b[bl - 1] - (int)a[al - 1] - jw;
                            jw = 0;
                            if (r < 0)
                            {
                                r = 10 + r;
                                jw++;
                            }
                        }
                    }
                    else if (bl > 0 && al <= 0)
                    {
                        r = b[bl - 1] - 48 - jw;
                        jw = 0;
                        if (r < 0)
                        {
                            r = 10 + r;
                            jw++;
                        }
                    }

                    if (r == 46)
                    {
                        item.Add(Convert.ToChar(r));
                    }
                    else
                    {
                        item.Add(Convert.ToChar(r.ToString()));
                    }
                    al--; bl--;
                } while (al > 0 || bl > 0);
            }
            else
            {
                if (a[0] > b[0])
                {
                    do
                    {
                        if (al > 0 && bl > 0)
                        {
                            if (a[al - 1] == '.')
                            {
                                r = '.';
                            }
                            else
                            {
                                r = (int)a[al - 1] - (int)b[bl - 1] - jw;
                                jw = 0;
                                if (r < 0)
                                {
                                    r = 10 + r;
                                    jw++;
                                }
                            }
                        }
                        else if (al > 0 && bl <= 0)
                        {
                            r = a[al - 1] - 48 - jw;
                            jw = 0;
                            if (r < 0)
                            {
                                r = 10 + r;
                                jw++;
                            }
                        }

                        if (r == 46)
                        {
                            item.Add(Convert.ToChar(r));
                        }
                        else
                        {
                            item.Add(Convert.ToChar(r.ToString()));
                        }
                        al--; bl--;
                    } while (al > 0 || bl > 0);
                }
                else
                {
                    fushu = true;
                    do
                    {
                        if (al > 0 && bl > 0)
                        {
                            if (b[bl - 1] == '.')
                            {
                                r = '.';
                            }
                            else
                            {
                                r = (int)b[bl - 1] - (int)a[al - 1] - jw;
                                jw = 0;
                                if (r < 0)
                                {
                                    r = 10 + r;
                                    jw++;
                                }
                            }
                        }
                        else if (bl > 0 && al <= 0)
                        {
                            r = b[bl - 1] - 48 - jw;
                            jw = 0;
                            if (r < 0)
                            {
                                r = 10 + r;
                                jw++;
                            }
                        }

                        if (r == 46)
                        {
                            item.Add(Convert.ToChar(r));
                        }
                        else
                        {
                            item.Add(Convert.ToChar(r.ToString()));
                        }
                        al--; bl--;
                    } while (al > 0 || bl > 0);
                }
            }
            if (item[item.Count() - 1] == '0' && item[item.Count() - 2] != '.')
            {
                item.RemoveAt(item.Count() - 1);
            }
            if (fushu)
            {
                item.Add('-');
            }
            List<char> ritems = new List<char>();

            for (int i = item.Count() - 1; i >= 0; i--)
            {
                ritems.Add(item[i]);

            }
            return ritems.ToArray();

        }
        public static char[] exponentiation(string a, int r)
        {
            char[] aa = new char[1];
            string b = "";
            string c = a;
            for (int i = 0; i < r - 1; i++)
            {
                aa = acm.Quadrature(c, a);
                b = "";
                foreach (var item in aa)
                {
                    b += item;
                }
                c = b;
            }
            return aa;
        }
        public static char[] Quadrature(string a, string b)
        {
            char[] r = new char[1] { '0' };
            List<int> bu = new List<int>();
            List<int> au = new List<int>();
            int adot = a.Length;
            int bdot = b.Length;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                if (b[i] == '.')
                {
                    bdot = i;
                }
                else
                {
                    bu.Add(b[i] - 48);
                }
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == '.')
                {
                    adot = i;
                }
                else
                {
                    au.Add(a[i] - 48);
                }
            }
            a = "";
            for (int i = au.Count() - 1; i >= 0; i--)
            {
                a += au[i];
            }

            for (int i = 0; i < bu.Count(); i++)
            {
                char[] qq = QuadUnit(a, bu[i]);
                string qqq = "";
                for (int j = 1; j < i + 1; j++)
                {
                    qqq = "";
                    foreach (var item in qq)
                    {
                        qqq += item;
                    }
                    qq = QuadUnit(qqq, 10);
                }
                qqq = "";
                foreach (var item in qq)
                {
                    qqq += item;
                }
                string rr = "";
                foreach (var item in r)
                {
                    rr += item;
                }
                r = SumF(rr, qqq);

            }
            List<char> rer = new List<char>();
            for (int i = 0; i < r.Count(); i++)
            {
                rer.Add(r[i]);
            }
            int con = rer.Count();
            int dot = a.Length + b.Length - (adot + bdot);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(a.Length);
            //Console.WriteLine(b.Length);
            //Console.WriteLine(adot);
            //Console.WriteLine(bdot);
            //Console.WriteLine(con);
            //Console.WriteLine(dot);
            //Console.WriteLine(con-dot);

            if (con - dot > 0)
            {
                if (con - dot != con)
                {
                    rer.Insert(con - dot + 1, '.');
                }
            }
            else if (con - dot < 0)
            {
                rer.Insert(0, '.');
                rer.Insert(0, '0');

                int co = -1 * (con - dot) - 1;
                while (co > 0)
                {
                    rer.Insert(2, '0');
                    co--;
                }
            }
            else
            {
                rer.Insert(0, '.');
                rer.Insert(0, '0');
            }

            return rer.ToArray();
        }
        public static char[] QuadUnit(string a, int b)
        {
            int r = 0;
            int jw = 0;
            char[] c = a.ToCharArray();
            List<char> items = new List<char>();
            List<char> ritems = new List<char>();
            for (int i = c.Count() - 1; i >= 0; i--)
            {
                if (a[i] == '.')
                {
                    r = '.';
                    items.Add(Convert.ToChar(r));
                }
                else
                {
                    r = ((int)c[i] - 48) * b + jw;
                    jw = 0;
                    if (r >= 10)
                    {
                        jw = r / 10;
                        r %= 10;
                    }
                    items.Add(Convert.ToChar(r.ToString()));
                }

            }
            if (jw > 0)
            {
                items.Add(Convert.ToChar(jw.ToString()));
            }

            for (int i = (items.Count() - 1); i >= 0; i--)
            {
                ritems.Add(items[i]);
            }
            return ritems.ToArray();
        }
        #endregion

        public static void acm1002(string[] azx)
        {

            string[] a = new string[azx.Length];
            for (int i = 0; i < azx.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                azx[i] = azx[i].Replace("-", "");
                for (int j = 0; j < azx[i].Length; j++)
                {

                    char cr = azx[i][j];
                    if (cr == 'A' || cr == 'B' || cr == 'C')
                    {
                        sb.Append("2");
                    }
                    else if (cr == 'D' || cr == 'E' || cr == 'F')
                    {
                        sb.Append("3");
                    }
                    else if (cr == 'G' || cr == 'H' || cr == 'I')
                    {
                        sb.Append("4");
                    }
                    else if (cr == 'J' || cr == 'K' || cr == 'L')
                    {
                        sb.Append("5");
                    }
                    else if (cr == 'M' || cr == 'N' || cr == 'O')
                    {
                        sb.Append("6");
                    }
                    else if (cr == 'P' || cr == 'R' || cr == 'S')
                    {
                        sb.Append("7");
                    }
                    else if (cr == 'T' || cr == 'U' || cr == 'V')
                    {
                        sb.Append("8");
                    }
                    else if (cr == 'W' || cr == 'X' || cr == 'Y')
                    {
                        sb.Append("9");
                    }
                    else
                    {
                        sb.Append(cr);
                    }
                }
                a[i] = sb.ToString();
            }
            int[] items = new int[a.Length];
            int bbbb = 0;
            foreach (var item in a)
            {

                items[bbbb] = Convert.ToInt32(item);
                bbbb++;

            }
            QSortDIY(items, 0, items.Length - 1);
            // Console.WriteLine(string.Join(",", items));
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in items)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic[item]++;
                }
            }
            foreach (var item in dic)
            {
                if (item.Value != 1)
                {
                    string s = item.Key.ToString();
                    s = s.Insert(3, "-");
                    Console.WriteLine(s + " " + item.Value);
                }
            }

        }

        public static void MPSort(int[] array)
        {
            int tep;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tep = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tep;
                    }
                }
            }
        }
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void QSortDIY(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int ie = QSortUnit(array, low, high);
            QSortDIY(array, low, ie - 1);
            QSortDIY(array, ie + 1, high);
        }
        private static int QSortUnit(int[] array, int low, int high)
        {
            int key = array[low];
            while (low < high)
            {
                while (array[high] >= key && high > low)
                {
                    --high;
                }
                array[low] = array[high];
                while (array[low] <= key && high > low)
                {

                    ++low;
                }
                array[high] = array[low];
            }
            array[low] = key;
            return high;
        }

        public static void acm1003(double a)
        {
            if (a == 0)
            {
                return;
            }
            double b = 2;
            while (a > 0)
            {
                double c = 1 / b;
                a = a - c;
                b++;
            }
            Console.WriteLine(b - 2 + " card(s)");
        }

        public static void acm1004(float[] a)
        {
            float sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            Console.WriteLine("$" + sum / a.Count());
        }

        public static void acm1005(int n, float[,] a)
        {
            float pi = 3.1415926f, rr;
            int years;
            for (int i = 0; i < n; i++)
            {
                rr = a[i, 0] * a[i, 0] + a[i, 1] * a[i, 1];
                int area = (int)(pi * rr);
                years = Convert.ToInt32(area / 100 + 1);
                Console.WriteLine(years);
            }
            Console.WriteLine("END OF OUTPUT.");
        }
        /// <summary>
        /// 中国剩余定理
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public static void acm1006(int a, int b, int c, int d)
        {
            int z = 28 * 33;
            int y = 23 * 33;
            int x = 23 * 28;
            int w = 23 * 28 * 33;
            int n = Acm1006Unit(z, 23) * z;
            int m = Acm1006Unit(y, 28) * y;
            int o = Acm1006Unit(x, 33) * x;
            int r = (n * a + m * b + o * c - d) % w;
            Console.WriteLine(r);
        }
        public static int Acm1006Unit(int a, int b)
        {
            int n = 1;
            while ((a * n) % b != 1)
                n++;
            return n;
        }

        public static void acm1007(int a, int b, string[] c)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            int[] i = new int[a];
            var j = 0;
            foreach (var item in c)
            {
                int k = Acm1007Unit(item);
                if (!dic.ContainsKey(k))
                {
                    i[j] = k;
                    j++;
                    dic.Add(k, item + ",");
                }
                else
                {
                    dic[k] += item + ",";
                    i[j] = -1;
                    j++;
                }
            }
             QSortDIY(i, 0, i.Length - 1);

            for (int jjj = 0; jjj < i.Length ; jjj++)
            {
                if (i[jjj] != -1)
                {
                    Console.Write(dic[i[jjj]]);
                }
            }

        }
        public static int Acm1007Unit(string a)
        {
            int anum = 0;
            int cnum = 0;
            int gnum = 0;

            int r = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                switch (a[i])
                {
                    case 'A':
                        anum++;
                        break;
                    case 'C':
                        r += anum;
                        cnum++;
                        break;
                    case 'G':
                        r += anum + cnum;
                        gnum++;
                        break;
                    case 'T':
                        r += anum + cnum + gnum;
                        break;
                }
            }
            return r;
        }


    }
}
