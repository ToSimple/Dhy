using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace English
{
    public partial class jsonp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string callback = Request.QueryString["callbackparam"];
            string data = "[{\"id\":\"1\",\"name\":\"测试1\"},{\"id\":\"2\",\"name\":\"测试2\"}]";
            string result = string.Format("{0}({1})", callback, data);
            Response.Expires = -1;
            Response.Clear();
            Response.ContentEncoding = Encoding.UTF8;
            Response.ContentType = "application/json";
            Response.Write(result);
            Response.Flush();
            Response.End();
        }
    }
}