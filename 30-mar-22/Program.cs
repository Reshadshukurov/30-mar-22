using _30_mar_22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_mar_22
{
    class Program
    {
        public static Rectangular Rectangular { get; private set; }

        static void Main(string[] args)
        {
            Square s = new Square();
            Rectangular r = new Rectangular();
            int input = 0;
            while (input<3&&input>=0)
            {
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        s.CalcArea();
                        break;
                    case 2:
                        r.CalcArea();
                        break;
                    case 0:

                        Console.WriteLine("Quit!");
                        break;


                }


            }
        }
    }
}
