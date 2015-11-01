using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tРобот - кот\n");
            Console.WriteLine("Введите возраст кота");
            var cat = new Model.Cat(Console.ReadLine(), new CatColor());
            var exit = false;
            String point;
            while (exit == false)
            {
                Console.WriteLine("Текущее состояние кошки:");
                Console.WriteLine("Имя: ");
                Console.WriteLine(cat.Name);
                Console.WriteLine("Возраст: ");
                Console.WriteLine(cat.Age);
                Console.WriteLine("Цвет: ");
                Console.WriteLine(cat.CurrentColor);

                Console.WriteLine(
                    "\tВыберите пункт меню:\na. Задать имя\nb. Покормить кошку\nc. Наказать кошку\nd. Изменить окрас кошки\n");

                point = Console.ReadLine();
                switch (point)
                {
                    case "a":
                        {
                            Console.Clear();
                            Console.WriteLine("\nВведите имя кошки\n");
                            cat.Name = Console.ReadLine();
                            break;
                        }
                    case "b":
                        {
                            Console.Clear();
                            cat.Feed();
                            Console.WriteLine("\nКошка покормлена\n");
                            break;
                        }
                    case "c":
                        {
                            Console.Clear();
                            cat.Punish();

                            Console.WriteLine("\nКошка наказана\n");
                            break;
                        }
                    case "d":
                        {
                            Console.Clear();
                            Console.WriteLine("\na. Установить цвет здоровой кошки\nb. Установить цвет больной кошки\n");
                            switch (Console.ReadLine())
                            {
                                case "a":
                                    {
                                        Console.WriteLine("Введите цвет здоровой кошки: ");
                                        cat.Color.HealthyColor = Console.ReadLine();
                                        break;
                                    }
                                case "b":
                                    {
                                        Console.WriteLine("Введите цвет больной кошки: ");
                                        cat.Color.SickColor = Console.ReadLine();
                                        break;
                                    }

                            }
                            Console.Clear();
                            //cat.Color = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\nВведены некоректные данные!\n");
                            break;
                        }
                }
            }
        }
    }
}
    
/*using System;
using Model;


namespace Cat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\t\tРобот - кот\n");
            Console.WriteLine("Введите возраст кота");
            var cat = new Model.Cat(Console.ReadLine(), new CatColor());
            var exit = false;
            String point;
            while (exit == false)
            {
                Console.WriteLine("Текущее состояние кошки:");
                Console.WriteLine("Имя: ");
                Console.WriteLine(cat.Name);
                Console.WriteLine("Возраст: ");
                Console.WriteLine(cat.Age);
                Console.WriteLine("Здоровье: ");
                Console.WriteLine(cat.Helth);
                Console.WriteLine("Цвет: ");
                Console.WriteLine(cat.CurrentColor);
                
                Console.WriteLine(
                    "\tВыберите пункт меню:\na. Задать имя\nb. Покормить кошку\nc. Наказать кошку\nd. Изменить окрас кошки\n");
                
                point = Console.ReadLine();
                switch (point)
                {
                    case "a":
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведите имя кошки\n");
                        cat.Name = Console.ReadLine();
                        break;
                    }
                    case "b":
                    {
                        Console.Clear();
                        cat.Feed();
                        Console.WriteLine("\nКошка покормлена\n");
                        break;
                    }
                    case "c":
                    {
                        Console.Clear();
                        cat.Punish();

                        Console.WriteLine("\nКошка наказана\n");
                        break;
                    }
                    case "d":
                    {
                        Console.Clear();
                        Console.WriteLine("\na. Установить цвет здоровой кошки\nb. Установить цвет больной кошки\n");
                        switch (Console.ReadLine())
                        {
                            case "a":
                            {
                                Console.WriteLine("Введите цвет здоровой кошки: ");
                                cat.Color.HeathyColor = Console.ReadLine();
                                break;
                            }
                            case "b":
                            {
                                Console.WriteLine("Введите цвет больной кошки: ");
                                cat.Color.SickColor = Console.ReadLine();
                                break;
                            }
                            
                        }
                        Console.Clear();
                        break;
                    }
                   default:
                    {
                        Console.Clear();
                        Console.WriteLine("\nВведены некоректные данные!\n");
                        break;
                    }
                }
            }
        }
    }
}
*/