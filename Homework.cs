using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstLibrary;

namespace Lesson2
{
    internal class Homework
    {
        static void Task1()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Задание {1}");
            Console.WriteLine($"Студент: {"Черепанов Вячеслав Андреевич"}");
            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine(new string('=', 55));


            Console.Write("Введите первое чиисло: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе чиисло: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье чиисло: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Минимальное число: {(a <= b && a <= c ? a : b <= c && b <= c ? b : c)}");

            Console.ReadKey();
            Console.Clear();
        }
        static void Task2()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Задание {2}");
            Console.WriteLine($"Студент: {"Черепанов Вячеслав Андреевич"}");
            Console.WriteLine("Написать метод подсчета количества цифр числа.");
            Console.WriteLine(new string('=', 55));
           
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            

            while (n != 0)
            {
                counter++;
                n = n / 10;
            }
            Console.WriteLine($"Количество цифр в  числе  {counter} ");
            Console.ReadKey();
            Console.Clear();

        }
        static void Task3()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Задание {3}");
            Console.WriteLine($"Студент: {"Черепанов Вячеслав Андреевич"}");
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0.\nПодсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine(new string('=', 55));
            
            #region решение задачи
            int sum = 0;
            int number;

            Console.WriteLine("Введите число : ");

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number % 2 == 1)
                {
                    sum = sum + number;
                }

            } while (number != 0);
            #endregion
            Console.WriteLine($"Сумма нечётных чисел: {sum}");
            Console.ReadKey();
            Console.Clear();
        }
        static void Task4()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Задание {4}");
            Console.WriteLine($"Студент: {"Черепанов Вячеслав Андреевич"}");
            Console.WriteLine("Реализовать метод проверки логина и пароля.\nЛогин: root, Password: GeekBrains).");
            Console.WriteLine(new string('=', 45));
            

            string a = "root";
            string b = "GeekBrains";
            string login;
            string password;
            int inputAttempt = 3;
            do
            {
                inputAttempt--;
                Console.Write("Введите Логин:");
                login = Console.ReadLine();

                Console.Write("Введите пароль:");
                password = Console.ReadLine();

                if (login == a && password == b)
                {
                    Console.WriteLine("Доступ разрешён!");
                    break;
                }

                else if (login != a || password != b)
                {
                    Console.WriteLine($"Осталось {inputAttempt} из 3 попыток");
                }

                if (inputAttempt == 0)
                {
                    Console.WriteLine("Доступ заблокирован!");
                }

            } while (inputAttempt != 0);

            Console.ReadKey();
            Console.Clear();
        }
        static void Task5()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Задание {5}");
            Console.WriteLine($"Студент: {"Черепанов Вячеслав Андреевич"}");
            Console.WriteLine("*Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            Console.WriteLine(new string('=', 80));
          
            Console.Write("Введите ваш рост в см: ");
            double h = int.Parse(Console.ReadLine());

            Console.Write("Введите ваш вес в кг: ");
            double m = double.Parse(Console.ReadLine());

            h = h / 100;
            double imt = m / (h * h);

            double MaxNormTelo = 25 * (h * h);
            double MinNormTelo = 19 * (h * h);
            if (imt > 25)
            {
                double res = m - MaxNormTelo;
                Console.WriteLine($"Вам бы  сбросить {res:F2} кг");
            }
            else if (imt < 19)
            {
                double res = MinNormTelo - m;
                Console.WriteLine($"Вам бы набрать {res:F2} кг");
            }
            else
            {
                Console.WriteLine($"Ваш вес {m}кг - идеален!!!");
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void Task6()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($" Задание {6}");
            Console.WriteLine($"Студент: {"Черепанов Вячеслав Андреевич"}");
            Console.WriteLine("Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000\nРеализовать подсчёт времени выполнения программы, используя структуру DateTime.");
            Console.WriteLine(new string('=', 90));
          
            TitlePage.Pause();
            
            DateTime start = DateTime.Now;
            #region Нахождение хороших чисел
            for (int i = 1; i <= 100000000; i++)         
            {
                int sumN = 0;
                int n = i;

                while (n != 0)       
                {
                    sumN++;
                    n = n / 10;                
                }
                if(i % sumN == 0)
                    
                Console.WriteLine($"{i}");   
            }
            #endregion
            

            Console.WriteLine($"Время выполнения: {DateTime.Now - start} мс");

        }
        static void Task7()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Задание {7}");
            Console.WriteLine($"Студент: {"Черепанов Вячеслав Андреевич"}");
            Console.WriteLine("Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine(new string('=', 80));
            
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число,больше первого");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 55));

             f(a,b);

            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {

            Console.SetCursorPosition((Console.WindowWidth - 10) / 2, Console.WindowHeight / 25);
            Console.WriteLine("Домашняя работа");

            bool f = true;
            while (f)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("6 -> Задача 6");
                Console.WriteLine("6 -> Задача 7");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================");
                Console.WriteLine();
                Console.Write("Введите номер задачи: ");
                
                int number = int.Parse(Console.ReadLine());

                switch(number)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
                        break;

                    case 6:
                        Task6();
                        break;

                    case 7:
                        Task7();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                        break;

                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;

                }
			
            }

            Console.ReadKey();
        }

                static void f(int a, int b)
                {

                if (b != a + 2)
                {
                f(a, b - 1);
                }
                Console.WriteLine(b - 1);
                }




    }
}