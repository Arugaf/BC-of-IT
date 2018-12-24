using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6
{
    delegate int PlusOrMinus(int p1, int p2);
    class Program
    {
        //Методы, реализующие делегат (методы "типа" делегата)
        static int Plus(int p1, int p2) { return p1 + p2; }
        static int Minus(int p1, int p2) { return p1 - p2; }
        //Пример объявления метода с делегатным параметром
        static void PlusOrMinusMethod(string str, int i1, int i2, PlusOrMinus PlusOrMinusParam)
        {
            int Result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void PlusOrMinusMethodFunc(string str, int i1, int i2, Func<int, int, int> PlusOrMinusParam)
        {
            int Result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void Main(string[] args)
        {
            int i1 = 3;
            int i2 = 2;
            PlusOrMinusMethod("Плюс: ", i1, i2, Plus);
            PlusOrMinusMethod("Минус: ", i1, i2, Minus);
            //Создание экземпляра делегата на основе метода
            PlusOrMinus pm1 = new PlusOrMinus(Plus);
            PlusOrMinusMethod("Создание экземпляра делегата на основе метода: ",
           i1, i2, pm1);
            //Создание экземпляра делегата на основе 'предположения' делегата
            //Компилятор 'пердполагает' что метод Plus типа делегата
            PlusOrMinus pm2 = Plus;
             PlusOrMinusMethod("Создание экземпляра делегата на основе 'предположения' делегата: ", i1, i2, pm2);
            //Создание анонимного метода
            PlusOrMinus pm3 = delegate (int param1, int param2)
            {
                return param1 + param2;
            };
            PlusOrMinusMethod("Создание экземпляра делегата на основе анонимного метода: ", i1, i2, pm2);
           
            PlusOrMinusMethod("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2,
            (int x, int y) =>
            {
                int z = x + y;
                return z;
            }
            );
            //Для обобщённого делегата 
            PlusOrMinusMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Minus);            PlusOrMinusMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 3:", i1, i2, (x, y) => x - y);
            Console.ReadKey();
        }
    }
}
