using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public abstract class CUsa : ICoffe
    {
        public IIncludeing Include()
        {
            return new NWater();
        }
        public abstract float Price();

        public abstract string Name();
    }
}
