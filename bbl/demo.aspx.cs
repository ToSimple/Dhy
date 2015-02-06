using bbl.Helpers;
using bbl.model;
using SubSonic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bbl
{
    public partial class demo : System.Web.UI.Page
    {
        public string GetVariableStr;//注意变量的修饰符
        SimpleRepository _repo = SS.GetRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetVariableStr = _repo.All<Ticker>().FirstOrDefault().Number; ;
            }   

        }
        protected string GetFunctionStr()//注意返回值的修饰符
        {
            return _repo.All<Ticker>().FirstOrDefault().Username;
        }
    }
}