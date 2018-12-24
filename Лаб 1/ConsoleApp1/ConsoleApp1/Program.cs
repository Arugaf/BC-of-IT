using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D;
            int check;

            Console.Write("Введите коэффициент А: ");
            string A1 = Console.ReadLine();

            while ((Double.TryParse(A1, out a) == false))
            {
                Console.WriteLine("Некорректный ввод. Введите повторно коэффициент А: ");
                A1 = Console.ReadLine();
            }
            a = Convert.ToDouble(A1);

            //_______________________________________________________________________________

            Console.Write("Введите коэффициент В: ");
            string B1 = Console.ReadLine();

            while ((Double.TryParse(B1, out b) == false))
            {
                Console.WriteLine("Некорректный ввод. Введите повторно коэффициент В: ");
                B1 = Console.ReadLine();
            }
            b = Convert.ToDouble(B1);

            //_______________________________________________________________________________

            Console.Write("Введите коэффициент С: ");
            string C1 = Console.ReadLine();

            while ((Double.TryParse(C1, out c) == false))
            {
                Console.WriteLine("Некорректный ввод. Введите повторно коэффициент С: ");
                C1 = Console.ReadLine();
            }
            c = Convert.ToDouble(C1);

            //_______________________________________________________________________________

            if (a != 0)
            {

                if (b != 0)
                {
                    if (c != 0) check = 1;
                    else check = 4;
                }
                else
                {
                    if (c != 0) check = 3;
                    else check = 7;
                }
            }

            else
            {
                if (b != 0)
                {
                    if (c != 0) check = 2;
                    else check = 6;
                }
                else
                {
                    if (c != 0) check = 5;
                    else check = 8;
                }
            }

            D = b * b - 4 * a * c; //Вычисление дискриминанта

            double sqrt_D = 0;

            if (D > 0)
            {

                sqrt_D = Math.Sqrt(D); //Вычисление корня из дискриминанта для дальнейшего использования 

            }

            double q;
            q = 2 * a; //переменная, введенная для удобства, с целью использования в вычислениях


            switch (check)
            {

                case 1:

                    {

                        if (D > 0) Console.Write("Дискриминант равен " + D + ", 2 корня: " + ((-b + sqrt_D) / q) + ", " + (-b - sqrt_D) / q);
                        else if (D == 0) Console.Write("Дискриминант равен 0, 1 корень (2 совпадающих корня): " + -b / q);
                        else Console.Write("Дискриминант меньше нуля, нет корней");
                        break;

                    }

                case 2:
                    {
                        Console.Write("1 корень: " + -c / b);
                        break;
                    }

                case 3:
                    {
                        if (-c / a >= 0) Console.Write("2 корня: " + sqrt_D / q + ", " + (-sqrt_D / q));
                        else Console.Write("Нет корней");
                        break;
                    }

                case 4:
                    {
                        Console.Write("2 корня: " + 0 + ", " + (-b / a));
                        break;
                    }

                case 5:
                    {
                        Console.Write("Нет корней");
                        break;
                    }

                case 6:
                    {
                        Console.Write("1 корень: 0");
                        break;
                    }

                case 7:
                    {
                        Console.Write("1 корень (2 совпадающих корня): 0");
                        break;
                    }

                case 8:
                    {
                        Console.Write("Бесконечное количество корней");
                        break;
                    }

            }


            Console.ReadKey();
        }
    }
}
