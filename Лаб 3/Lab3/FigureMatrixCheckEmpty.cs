using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    partial class FigureMatrixCheckEmpty: IMatrixCheckEmpty<Figure>
    {
        //реализация первого метода интерфейса
        public Figure getEmptyElement()
        {
            return null;
        }

        public bool CheckEmptyElement(Figure element)
        {
            bool Result = false;
            if(element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}
