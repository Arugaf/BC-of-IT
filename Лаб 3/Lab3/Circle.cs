using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    partial class Circle : Figure, Interface1
    {
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set { this._Radius = value; }
        }

        public Circle(double R)
        {
            this.Radius = R;
            this.Type = "Круг";
        }

        public override double Area()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public void Print()
        {
            
            Console.WriteLine(this.ToString());
            Console.WriteLine("Радиус: " + this.Radius);
        }
    }
}
