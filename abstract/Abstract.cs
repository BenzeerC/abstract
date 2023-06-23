using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
    
{
    public interface IPrintDatials
    {
        void PrintDatials();
    }
    abstract public class Shape
    {
        public Shape()
        {
        }

        public abstract void CalculateArea();

        public string Display()
        {
            return "In the abstract class:";
        }

    }
    public class Circle : Shape, IPrintDatials
    {
        private int r;
        private double area;

        public Circle(int r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }

        public void PrintDatials()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Area is:{area}";
        }


    }
    public class Rectangle : Shape, IPrintDatials
    { 
            private int l, b,area;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            area = 2 *(l + b);
        }

        public void PrintDatials()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Area of Rectangle is:{area}";
        }
       
    }
}
