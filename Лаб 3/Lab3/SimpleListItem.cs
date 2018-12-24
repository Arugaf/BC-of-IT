using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // Элемент списка
    partial class SimpleListItem<T>
    {       
        //Данные
        public T data { get; set; }

        //Следующий элемент
        public SimpleListItem<T> next { get; set; }

        // конструктор
        public SimpleListItem(T param)
        {
            this.data = param;
        }
    }
}
