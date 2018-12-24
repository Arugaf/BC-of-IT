using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   abstract partial class Figure : IComparable
    {
        private string _Type;
       
        public string Type
        {
            get { return this._Type; }
            set { this._Type = value; }
        }
       
        abstract public double Area();

        public override string ToString()
        {
            //Console.WriteLine(this.Type + ":");
            return this.Type + " с площадью " + this.Area().ToString();
            
        }

        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;
            if (this.Area() > p.Area())
            {
                return 1;
            }
            else if (this.Area() < p.Area())
            {
                return -1;
            }
            else if(this.Area() == p.Area())
            {
                return 0;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

       
    }
}
