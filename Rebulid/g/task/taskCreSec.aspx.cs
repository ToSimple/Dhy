using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class g_task_taskCreSec : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(1000);
        string s = Request.QueryString["userIds"];
        string name = Request.QueryString["name"];
        string callback = Request.QueryString["jsoncallback"];
        string data = "";
        if (s != null)
        {
            string[] key = s.Split(',');
            data = "{\"users\":[";
            foreach (var item in key)
            {
                if (item == "1")
                {
                    data += "{\"name\":\"John\" , \"id\":\"1\" },";
                    data += "{\"name\":\"John\" , \"id\":\"1\" },";
                    data += "{\"name\":\"John\" , \"id\":\"1\" },";
                }
                else if (item == "2")
                {
                    data += "{ \"name\":\"dd\" , \"id\":\"2\" },";
                }
                else if (item == "3")
                {
                    data += "{ \"name\":\"cc\" , \"id\":\"3\" },";
                }
                else if (item == "4")
                {
                    data += "{ \"name\":\"ee\" , \"id\":\"4\" },";
                }              
            }
            if (data[data.Length - 1] == ',')
            {
                data = data.Remove(data.Length - 1);
            }
            data += "]}";
        }
        if (name != null)
        {
            data = "{\"users\":[";
            if (name == "John")
            {
                data += "{\"name\":\"John\" , \"id\":\"1\" }";
            }
            else if (name == "dd")
            {
                data += "{ \"name\":\"dd\" , \"id\":\"2\" }";
            }
            else if (name == "cc")
            {
                data += "{ \"name\":\"cc\" , \"id\":\"3\" }";
            }
            else if (name == "ee")
            {
                data += "{ \"name\":\"ee\" , \"id\":\"4\" }";
            }

            data += "]}";
        }
        string result = string.Format("{0}{1}", callback, data);
        Response.Expires = -1;
        Response.Clear();
        Response.ContentEncoding = Encoding.UTF8;
        Response.ContentType = "application/json";
        Response.Write(result);
        Response.Flush();
        Response.End();
    }
}