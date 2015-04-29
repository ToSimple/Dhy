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
        string callback = Request.QueryString["jsoncallback"];
        string data = "{\"users\":[{ \"name\":\"John\" , \"id\":\"1\" },{ \"name\":\"dd\" , \"id\":\"2\" },{ \"name\":\"cc\" , \"id\":\"3\" },{ \"name\":\"ee\" , \"id\":\"4\" }]}";
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