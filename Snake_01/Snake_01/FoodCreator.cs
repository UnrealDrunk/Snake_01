using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_01
{
    class FoodCreator
    {

        int mapwidth;
        int mapheight;
        char sym;
        Random random = new Random();

        public FoodCreator(int mapwidth, int mapheight, char sym)
        {
            this.mapwidth = mapwidth;
            this.mapheight = mapheight;
            this.sym = sym;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapwidth - 2);
            int y = random.Next(2, mapheight - 2);
            return new Point(x, y, sym);
        }
    }
}
