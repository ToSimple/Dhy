using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public class Latte:CItaly
    {

        public override float Price()
        {
            return 18f;
        }
        public override string Name()
        {
            return "Italy Latte";
        }
    }
}
