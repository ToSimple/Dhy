using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTMLbug
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> urlListUp = new List<string>();
            List<string> urlListDown = new List<string>();

            Dictionary<string, int> urldicUp = new Dictionary<string, int>();
            Dictionary<string, int> urldicDown = new Dictionary<string, int>();

            urlListUp.Add("http://fanyi.baidu.com/#en/zh/nice");
            while (urlListUp.Count>0)
            {
                string url = urlListUp.First();
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";
                req.Accept = "text/html";
                req.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0)";
                urlListUp.Remove(url);
                try
                {
                    string html = null;
                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                    using (StreamReader reader = new StreamReader(res.GetResponseStream()))
                    {
                        html = reader.ReadToEnd();
                        if (!string.IsNullOrEmpty(html))
                        {
                            using (StreamWriter fs = new StreamWriter("1.txt"))
                            {
                                fs.Write(html);
                            }
                            Console.WriteLine("Download OK!\n");
                        }
                    }
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
