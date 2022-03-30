using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_mar_22.Models
{
    class Rectangular:Figure
    {
        public double width 
        {
            get { return width; } 
            set
            {
                if (width > 0)
                {
                    width = value;
                }

            }
        }
        public double length
        {
            get { return length; }
            set
            {
                if (length > 0)
                {
                    length = value;
                }

            }
        }
        public Rectangular(double width,double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangular()
        {
        }

        public override void CalcArea()
        {
            Console.WriteLine("width*length");
        }

    }
}
