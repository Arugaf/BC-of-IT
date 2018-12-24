using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    partial class Rectangle : Figure, Interface1
    {
       
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set { this._Height = value; }
        }
        
        private double _Width;
        public double Width
        {
            get { return this._Width; }
            set { this._Width = value; }
        }


        public Rectangle(double h, double w)
        {
            this.Height = h;
            this.Width = w;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            double res = this.Width * this.Height;
            return res;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine("Высота: " + this.Height);
            Console.WriteLine("Ширина: " + this.Width);
        }
    }
}
