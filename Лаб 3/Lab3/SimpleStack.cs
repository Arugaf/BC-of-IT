using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// класс стек
    /// </summary>
   
    partial class SimpleStack<T> : SimpleList<T> where T : IComparable
    {
        /// <summary>
        /// добавление в стек
        /// </summary>
        public void Push(T element)
        {
            Add(element);
        }

        /// <summary>
        /// удаление и чтение из стека
        /// </summary>
        public T Pop()
        {
            //default - значение по умолчанию
            T Result = default(T);
            if(this.Count == 0)
            {
                return Result;
            }
            if(this.Count == 1)
            {
                Result = this.first.data;
                this.first = null;
                this.last = null;
            }
            else
            {
                //поиск предпоследнего элемента
                SimpleListItem<T> newLast = this.GetItem(this.Count - 2);
                //чтение из последнего элемента
                Result = newLast.next.data;
                //предпоследний элемент считается последним
                this.last = newLast;
                //последний элемент удаляется
                newLast.next = null;
            }
            //уменьшение количества элементов в списке
            this.Count--;
            //возврат результата
            return Result;
        }
    }
}
