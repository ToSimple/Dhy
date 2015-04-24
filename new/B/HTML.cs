using newweb.I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newweb.B
{
    public class HTML : IHTML
    {
        public Tube DocName()
        {
            Tube te = new Tube();
            te.Head = "<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\">";
            te.Foot = "</html>";
            return te;
        }
    }
}