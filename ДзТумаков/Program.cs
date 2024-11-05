// лабораторная работа 1
//2.1 программа спрашивает имя пользователя, затем приветствует его по имени

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
//2.2 на вход подаются 2 числа, результат - деление одного на другое (с учетом запрета деления на 0)
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (b != 0)
            {
               Console.WriteLine(a / b);

            }
            if (b == 0)
            {
                Console.WriteLine("На нуль делить нельзя!");
                
            }
        }
    }
}
// домашнее задание
// 2.1 прочитать букву с экрана, затем вывести след букву в алфавитном порядке
using System;
namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            char let = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(let))
            {
                char newlet = (char)(let + 1);
                Console.WriteLine($"следующая буква после {let}: {newlet}");
            }
            else
            {
                Console.WriteLine("не буква");
                
            }
        }
    }
}
// 2.2 программа решает квадратное ур-е, на входе коэффициенты ур-я
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
