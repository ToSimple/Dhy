using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.FactoryPatternOfAbstract
{
    class MonsterFactory : AbstractFactory
    {
        public override IWeapon getWeapon(String weapon)
        {
            return null;
        }
        public override IMonster getMonster(String monster)
        {
            if (monster == null)
            {
                return null;
            }
            if (monster.ToUpper().Equals("ORC"))
            {
                return new Orc();
            }
            else if (monster.ToUpper().Equals("WOLFMAN"))
            {
                return new Wolfman();
            }
            else if (monster.ToUpper().Equals("GHOST"))
            {
                return new Ghost();
            }
            return null;
        }
    }
}
