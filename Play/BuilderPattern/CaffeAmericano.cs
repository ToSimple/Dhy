using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public class CaffeAmericano:CUsa
    {
        public override float Price()
        {
            return 14f;
        }
        public override string Name()
        {
            return "Caffe Americano";
        }
    }
}
