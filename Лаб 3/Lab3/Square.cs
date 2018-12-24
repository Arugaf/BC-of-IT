using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    partial class Square : Rectangle, Interface1
    {
        public Square(double size) : base(size,size)
        {
            this.Type = "Квадрат";
        }
    }
}
