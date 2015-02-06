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
        SimpleRepository _repo = SS.GetRepo();
        protected void Page_Load(object sender, EventArgs e)
        {

            t1.Value = _repo.All<Ticker>().FirstOrDefault().Number;
        }
    }
}