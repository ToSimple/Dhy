using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.FactoryPatternOfAbstract
{
    class WeaponFactory : AbstractFactory
    {
        public override IWeapon getWeapon(String weapon)
        {
            if (weapon == null)
            {
                return null;
            }
            if (weapon.ToUpper().Equals("BOW"))
            {
                return new Bow();
            }
            else if (weapon.ToUpper().Equals("SWORD"))
            {
                return new Sword();
            }
            else if (weapon.ToUpper().Equals("SPEAR"))
            {
                return new Spear();
            } return null;
        }
        public override IMonster getMonster(String monster)
        {
            return null;
        }
    }
}
