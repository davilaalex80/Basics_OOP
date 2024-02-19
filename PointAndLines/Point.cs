using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP.PointAndLines
{
    class Point
    {
        private int x;
        public int y;

        public int X
        {
            get { return x; } 
            set { x = value;}
        }

        //empty constructor
        public Point()
        {

        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
