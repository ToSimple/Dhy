﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.FactoryPatternOfAbstract
{
    class Bow:IWeapon
    {
        public void Equip()
        {
            Console.WriteLine("Equip Bow");
        }
    }
}
