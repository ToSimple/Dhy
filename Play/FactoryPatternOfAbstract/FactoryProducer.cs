using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.FactoryPatternOfAbstract
{
    class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {
            if (choice.ToUpper().Equals("MONSTER"))
            {
                return new MonsterFactory();
            }
            else if (choice.ToUpper().Equals("WEAPON"))
            {
                return new WeaponFactory();
            }
            return null;
        }
    }
}
