using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public class NWater : IIncludeing
    {
        public string Include()
        {
            return "Water";
        }
    }
}
