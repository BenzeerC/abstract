using abstractclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle  c1 = new Circle(5);
            c1.CalculateArea();
            Console.WriteLine(c1.ToString());
           // Console.WriteLine(c1.PrintDatials());

            Rectangle r1 = new Rectangle(7, 8);
            r1.CalculateArea();
            Console.WriteLine(r1.ToString());
        }
    }
}
