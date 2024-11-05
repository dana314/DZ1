// 1 вывести на экран число е
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = Math.E;
            Console.WriteLine(e);
            Console.ReadKey();
        }

    }
}
//2 вывести на экран числа 50 и 10 одно под другим
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10);
            Console.WriteLine(50);
        }
    }
}
//3 программа выводит столбиком 4 любых числа 
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();
            Console.WriteLine("Число" + " " + n1);
            Console.WriteLine("Число" + " " + n2);
            Console.WriteLine("Число" + " " + n3);
            Console.WriteLine("Число" + " " + n4);
        }
    }
}
//4 пользователь вводит число, результат - число на 10 большее введенного
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a + 10);
        }
    }
}
//5 дана сторона квадрата, найти периметр
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double p = a * 4;
            Console.WriteLine(p);

        }
    }
}
//6 дан радиус, найти длину окр-ти и площадь круга
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double d = 2 * r * Math.PI;
            double s = Math.PI * r * r;
            Console.WriteLine($"длина окружности:{d} площадь круга: {s}");

        }
    }
}
//7 найти значение y= cos(x)
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine()); // градусы
            double x = a * Math.PI / 180;
            double y = Math.Cos(x);
            Console.WriteLine(y);

        }
    }
}
//8 даны осн-я и высота р/б трапеции, найти ее периметр
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Math.Sqrt(b * b + c * c);
            double p = d * 2 + a + b;
            Console.WriteLine(p);

        }
    }
}
//9 известна стоимость 1 кг конфет, печенья и яблок. найти стоимость всей покупки, если х кг конфет, у кг печенья,z кг яблок
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine()); //конфеты
            double b = Convert.ToDouble(Console.ReadLine()); //печенья
            double c = Convert.ToDouble(Console.ReadLine()); //яблоки

            double x = Convert.ToDouble(Console.ReadLine()); // вес конфет
            double y = Convert.ToDouble(Console.ReadLine()); // вес печенья
            double z = Convert.ToDouble(Console.ReadLine()); // вес яблок

            Console.WriteLine((a * x) + (b * y) + (c * z));
        }
    }
}
//10 программа выводит слова мир труд май 2мя разными способами
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("мир труд май");
            Console.WriteLine("мир");
            Console.WriteLine("   труд");
            Console.WriteLine("        май");

        }
    }
}
// 13 программа выводит: "Вы ввели число: (вводимое с клавиатуры число)"
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine("Вы ввели число" + " " + a);


        }
    }
}
// 14 вывести: 2кг, под этим 13 17
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");


        }
    }
}
//15 программа выводит 4 случайных числа
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();
            Console.WriteLine("Число" + " " + n1);
            Console.WriteLine("Число" + " " + n2);
            Console.WriteLine("Число" + " " + n3);
            Console.WriteLine("Число" + " " + n4);
        }
    }
}
//16 программа решает кв. ур-е, вводные данные - коэффициенты ур-я
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("а != 0");
            return;
        }

        double discr = b * b - 4 * a * c;

        if (discr > 0)
        {

            double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discr)) / (2 * a);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else if (discr == 0)
        {

            double x = -b / (2 * a);
            Console.WriteLine($"x = {x}");
        }
        else
        {

            Console.WriteLine("нет корней");
        }
    }
}
// 17 даны 2 числа, найти ср арифметическое и ср геометрическое
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a + b) / 2);
            Console.WriteLine(Math.Sqrt(a * b));
        }
    }
}
// 18 узнать расстояние между 2 точками с известными координатами
using System;
using System.Runtime.ConstrainedExecution;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

        }
    }
}
//19 а,б,с - вводные, 1) б присвоить значение с, а присв.знач. б, с присв.знач. а 2) б присв. а, с присв. б, а присв. с
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double b1 = b;
            b = c;
            c = a;
            a = b1;

            Console.WriteLine($"1: a={a} b={b} c={c}");

            double c1 = c;
            c = b;
            b = a;
            a = c1;
            Console.WriteLine($"2: a ={a}, b = {b}, c = {c}");
        }
    }
}
// 20 с начала суток прошло n секунд, 1) сколько полных часов 2) сколько полных минут с нач. очередн. часа 3) сколько полных секунд с нач. очередн. минуты
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(n / 3600);
            Console.WriteLine(n % 3600 / 60);
            Console.WriteLine(n % 60);
        }
    }
}
//21 дан прямоуг. 534*130. сколько квадратов со стороной 130 можно от него отрезать
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 543 * 130;
            Console.WriteLine(n / 130*130);
        }
    }
}
//22 дано трехзнач. число, в нем зачерк. посл. цифру и приписали ее в начале. какое число вышло
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 10;
            int c = a / 10;
            int d = b * 100 + c;
            Console.WriteLine(d);
        }
    }
}
// 23 дано число >999, найти число сотен; число тысяч
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100 % 10;
            int c = a / 1000 % 10;

            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
//24 дано число >999, найти 1) число прочтенное справа налево 2)перестановка 1 и 2, 3 и 4 цифр 3) перест. 2 и 3 цифр 4)перестан. 2 первых и 2 последних цифр
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string na = a.ToString();
            char da = na.ToCharArray();
            Array.Reverse(da);
            string f = new string(da);
            int ra = Convert.ToInt32(f);

            Console.WriteLine(ra);



        }
    }
}
// b
using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int a = h / 1000;
            int b = h / 100 % 10;
            int c = h / 10 % 10;
            int d = h % 10;
            int r = b * 1000 + a * 100 + d * 10 + c;



            Console.WriteLine(r);



        }
    }
}
// в
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int a = h / 1000;
            int b = h / 100 % 10;
            int c = h / 10 % 10;
            int d = h % 10;
            int r = a * 1000 + c * 100 + b * 10 + d;



            Console.WriteLine(r);



        }
    }
}
// г
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int a = h / 1000;
            int b = h / 100 % 10;
            int c = h / 10 % 10;
            int d = h % 10;
            int r = c * 1000 + d * 100 + a * 10 + b;



            Console.WriteLine(r);



        }
    }
}
// 28 программа выводит меньшее по модулю из 3 чисел
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double ma = Math.Abs(a);
            double ba = Math.Abs(b);
            double ca = Math.Abs(c);
            if ((ma > ba) && (ba > ca))
            {
                Console.WriteLine(ca);
            }
            if ((ma > ca) && (ca > ba))
            {
                Console.WriteLine(ba);
            }
            if ((ca > ba) && (ba > ma))
            {
                Console.WriteLine(ma);
            }

        }
    }
}
// 29 найти сумму больше и меньшего из 3 данных чисел
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double minn = Math.Min(Math.Min(a, b), c);
            double maxx = Math.Max(Math.Max(a, b), c);
            double s = minn + maxx;
            Console.WriteLine(s);

        }
    }
}
// 34 программа запрашивает имя человека, затем выводит его, приветствуя 
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
        }
    }
}