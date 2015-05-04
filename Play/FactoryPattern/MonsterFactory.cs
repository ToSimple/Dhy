using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.FactoryPattern
{
    class MonsterFactory
    {
        public IMonster GetMonster(string mType)
        {
            if (mType == null)
            {
                return null;
            }
            if (mType.ToUpper().Equals("ORC"))
            {
                return new Orc();
            }
            else if (mType.ToUpper().Equals("WOLFMAN"))
            {
                return new Wolfman();
            }
            return null;
        }
    }
}
