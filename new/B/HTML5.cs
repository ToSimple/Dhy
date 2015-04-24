using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newweb.B
{
    public class HTML5
    {
        public Tube DocName()
        {
            Tube te = new Tube();
            te.Head = "<!DOCTYPE html><html>";
            te.Foot = "</html>";
            return te;
        }
    }
}