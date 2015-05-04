using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.FactoryPatternOfAbstract
{
    public abstract class  AbstractFactory
    {
        public abstract IWeapon getWeapon(String weapon);
        public abstract IMonster getMonster(String monster);

    }
}
