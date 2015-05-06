using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public class LatteeAmericano:CUsa
    {
        public override float Price()
        {
            return 16f;
        }
        public override string Name()
        {
            return "Americano Latte";
        }
    }
}
