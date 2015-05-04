using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.FactoryPatternOfAbstract
{
    class Orc : IMonster
    {
        public void Say()
        {
            Console.WriteLine("Or!Ta!Ga!");
        }
    }
}
