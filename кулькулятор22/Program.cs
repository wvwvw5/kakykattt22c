using System;

class Calculator
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Факториал числа");
            Console.WriteLine("9. Выйти из программы");
            Console.Write("Введите номер операции: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                double result = 0.0;
                double num1, num2;

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 + num2;
                        break;
                    case 2:
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 - num2;
                        break;
                    case 3:
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * num2;
                        break;
                    case 4:
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль.");
                        }
                        break;
                    case 5:
                        Console.Write("Введите число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int exponent = Convert.ToInt32(Console.ReadLine());
                        result = Math.Pow(num1, exponent);
                        break;
                    case 6:
                        Console.Write("Введите число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        if (num1 >= 0)
                        {
                            result = Math.Sqrt(num1);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: квадратный корень от отрицательного числа.");
                        }
                        break;
                    case 7:
                        Console.Write("Введите число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = num1 / 100;
                        break;
                    case 8:
                        Console.Write("Введите число: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        result = CalculateFactorial(n);
                        break;
                    case 9:
                        Console.WriteLine("Программа завершена.");
                        break;
                    default:
                        Console.WriteLine("Ошибка: неверный выбор операции.");
                        break;
                }

                if (choice != 9)
                {
                    Console.WriteLine("Результат: " + result);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректный номер операции.");
            }

        } while (choice != 9);
    }

    static double CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
    
}

