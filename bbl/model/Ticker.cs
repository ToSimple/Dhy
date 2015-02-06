using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bbl.model
{
    public class Ticker
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Number { get; set; }
        public DateTime Createtime { get; set; }
        public DateTime endtime { get; set; }
    }
}