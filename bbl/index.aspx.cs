﻿using bbl.Helpers;
using SubSonic.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string postString = string.Empty;
       
        if (HttpContext.Current.Request.HttpMethod.ToUpper() == "POST")
        {
            using (Stream stream = HttpContext.Current.Request.InputStream)
            {
                Byte[] postBytes = new Byte[stream.Length];
                stream.Read(postBytes, 0, (Int32)stream.Length);
                postString = Encoding.UTF8.GetString(postBytes);
                Handle(postString);
            }
        }
        else
        {
            InterfaceTest();
        }
    }
    /// <summary>
    /// 处理信息并应答
    /// </summary>
    private void Handle(string postStr)
    {
        
        messageHelp help = new messageHelp();
        string responseContent = help.ReturnMessage(postStr);

        HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
        HttpContext.Current.Response.Write(responseContent);
    }
    //成为开发者url测试，返回echoStr
    public void InterfaceTest()
    {
        string token = "bkutmg1420622269";
        if (string.IsNullOrEmpty(token))
        {
            return;
        }

        string echoString = HttpContext.Current.Request.QueryString["echoStr"];
        string signature = HttpContext.Current.Request.QueryString["signature"];
        string timestamp = HttpContext.Current.Request.QueryString["timestamp"];
        string nonce = HttpContext.Current.Request.QueryString["nonce"];

        if (!string.IsNullOrEmpty(echoString))
        {
            HttpContext.Current.Response.Write(echoString);
            HttpContext.Current.Response.End();
        }
    }
}