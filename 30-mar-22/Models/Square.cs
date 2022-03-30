using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_mar_22.Models
{
    class Square:Figure
    {
        public int side 
        {
            get { return side; } 
            set 
            {
                if (side>0)
                {
                    side = value;
                }
            }
        }

        public override void CalcArea()
        {
            Console.WriteLine("side*side");
        }
        public Square(int side)
        {
            this.side = side;
        }

        public Square()
        {
        }
    }
}
