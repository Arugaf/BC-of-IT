using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class GeometryFigure
    {
        public abstract double Area();
    }

    interface IPrint
    {
        void Print();
    }

    class Rectangle : GeometryFigure, IPrint
    {
        public float Property1 { get; set; }
        public float Property2 { get; set; }

        public Rectangle(float Weight, float Height)
        {
            Property1 = Weight;
            Property2 = Height;
        }

        public override double Area()
        {
            return Property1 * Property2;
        }

        public void Print()
        {
            Console.WriteLine("Rectangle:\n" + ToString());
        }

        public override string ToString()
        {
            return "Width = " + Property1.ToString() + "\nHeight = " + Property2.ToString() + "\nS = " + Area().ToString() + "\n";
        }
    }


    class Square : Rectangle, IPrint
    {
        private float side;

        public Square(float s) : base(s, s) { side = s; }

        public new void Print()
        {
            Console.WriteLine("Square:\n" + ToString());
        }

        public override string ToString()
        {
            return "Side = " + side.ToString() + "\nS = " + Area().ToString() + "\n";
        }
    }


    class Circle : GeometryFigure, IPrint
    {
        private readonly float Property;
        public Circle(float R)
        {
            Property = R;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Property, 2);
        }

        public void Print()
        {
            Console.WriteLine("Circle:\n" + ToString());
        }

        public override string ToString()
        {
            return "R = " + Property.ToString() + "\nS = " + Area().ToString() + "\n";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle(6, 8);
            Rect.Print();
            Rect.Property1 = 3;
            Rect.Property2 = 4;
            Rect.Print();

            Square Sq = new Square(12);
            Sq.Print();


            Circle Cir = new Circle(9);
            Cir.Print();

            Console.ReadKey();
        }
    }
}