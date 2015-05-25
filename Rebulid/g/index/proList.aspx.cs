using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class g_index_proList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(500);
        string callback = Request.QueryString["jsoncallback"];
        string data = "{\"list\":[{\"id\":\"1\",\"img\":\"../img/default.jpg\",\"title\":\"创客的项目\"},{\"id\":\"2\",\"img\":\"../img/default.jpg\",\"title\":\"创客的项目\"},{\"id\":\"3\",\"img\":\"../img/default.jpg\",\"title\":\"创客的项目\"},{\"id\":\"4\",\"img\":\"../img/default.jpg\",\"title\":\"创客的项目\"},{\"id\":\"5\",\"img\":\"../img/default.jpg\",\"title\":\"创客的项目\"},{\"id\":\"6\",\"img\":\"../img/default.jpg\",\"title\":\"创客的项目\"},{\"id\":\"7\",\"img\":\"../img/default.jpg\",\"title\":\"创客的项目\"}] }";
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