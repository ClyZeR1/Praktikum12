using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Func(int x)
        {
//Задача 1. Вычислить значение выражения, определив и использовав дополнительный метод:
//            return (Math.Sqrt(x)-x)/2
//        }
//        static double Func2(double x,double y)
//        {
//            return (Math.Sqrt(x) + x) / Math.Sqrt(y);
//        }
//        static void Main(string[] args)
//        {
//            double x1 = Func1(5) - Func1(12) - Func1(19);
//            double x2 = Func2(5, 7) + Func2(12, 8) + Func2(19, 2);

//            Console.WriteLine($"Результат 1 задачи:{x1}");
//            Console.WriteLine($"Результат 2 задачи:{x2}");
//            Console.ReadLine();
//        }
//    }
//}

//Задача 2. Вычислить значение выражения, определив и использовав дополнительный метод:
//            return (Math.Sqrt(x) + x) / 2;
//        }
//        static void Main(string[] args)
//        {
//            double y = Func(5) + Func(7) + Func(12) + Func(8) + Func(19) + Func(2);
//            Console.WriteLine($"y={y}");
//            Console.ReadLine();
//        }
//    }
//}
//Задача 3. Найти максимальную величину из двух целых переменных a, b с использованием вспомогательных методов.
//        static int Max(int a, int b)
//        {
//            return a > b ? a : b;
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("a:");
//            int a = int.Parse(Console.ReadLine());

//            Console.Write("b:");
//            int b = int.Parse(Console.ReadLine());

//            int max = Max(a, b);
//            Console.WriteLine($"Максимальное значение: {max}");

//            Console.ReadLine();
//        }
//    }
//}
//Задача 4. Найти максимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов. 
//        static int Max(int a, int b)
//        {
//            return a > b ? a : b;
//        }
//        static int Max(int a, int b, int c)
//        {
//            return Max(Max(a, b), c);
//        }
//        static void Main(string[] args)
//        {
//            Console.Write("a:");
//            int a = int.Parse(Console.ReadLine());

//            Console.Write("b:");
//            int b = int.Parse(Console.ReadLine());

//            Console.Write("c:");
//            int c = int.Parse(Console.ReadLine());

//            int max = Max(a, b, c);
//            Console.WriteLine($"Максимальное значение: {max}");

//            Console.ReadLine();
//        }
//    }
//}
//Задача 5. Найти s=max(a, b) + max(c, d), используя вспомогательную функцию (метод).
//        static int Max(int x, int y)
//        {
//            return x > y ? x : y;
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("a:");
//            int a = int.Parse(Console.ReadLine());

//            Console.Write("b:");
//            int b = int.Parse(Console.ReadLine());

//            Console.Write("c:");
//            int c = int.Parse(Console.ReadLine());

//            Console.Write("d:");
//            int d = int.Parse(Console.ReadLine());

//            int s = Max(a, b) + Max(c, d);
//            Console.WriteLine($"s = {s}");

//            Console.ReadLine();
//        }
//    }
//}
//Задача 6. Вывести дни недели в зависимости от номера дня с использованием вспомогательного метода.
//        static string GetDayOfWeek(int dayNumber)
//        {
//            switch (dayNumber)
//            {
//                case 1: return "Понедельник";
//                case 2: return "Вторник";
//                case 3: return "Среда";
//                case 4: return "Четверг";
//                case 5: return "Пятница";
//                case 6: return "Суббота";
//                case 7: return "Воскресенье";
//                default: return "Некорректный номер дня";
//            }
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("Введите номер дня недели (1-7): ");
//            int dayNumber = int.Parse(Console.ReadLine());

//            string day = GetDayOfWeek(dayNumber);
//            Console.WriteLine($"День недели: {day}");

//            Console.ReadLine();
//        }
//    }
//}