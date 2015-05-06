using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public class Meal
    {
        private List<ICoffe> coffes = new List<ICoffe>();
        public void AddCoffe(ICoffe c)
        {
            coffes.Add(c);
        }
        public float getCost()
        {
            float cost = 0.0f;
            foreach (var item in coffes)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (var item in coffes)
            {
                Console.Write("Item : " + item.Name());
                Console.Write(", Packing : " + item.Include().Include());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}
