using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class asp1 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string Id =Request.Form["base64"];
        string path = @"d:\t.txt";
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(Id);
            }
        }
        Response.Write(Id);
        Response.End();
    }


   
}