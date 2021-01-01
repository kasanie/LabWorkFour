using System;

namespace LabWorkFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput;
            int secondInput;
            int minNumber;
            int maxNumber;
            Console.WriteLine("Для создания двумерного массива вам нужно ввести два разных числа.\r\nВведите первое число:");
            for (; ; )
            {
                for (; ; )
                {
                    if (int.TryParse(Console.ReadLine(), out firstInput))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите первое число:");
                        continue;
                    }
                }
                Console.WriteLine("Введите второе число:");
                for (; ; )
                {
                    if (int.TryParse(Console.ReadLine(), out secondInput))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите второе число:");
                        continue;
                    }

                }
                if (firstInput < secondInput)
                {
                    minNumber = firstInput;
                    maxNumber = secondInput;
                    break;
                }
                else if (firstInput > secondInput)
                {
                    minNumber = secondInput;
                    maxNumber = firstInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите два разных числа:");
                    continue;
                }
            }
            Random randomNumber = new Random();
            int firstValue, secondValue;
            int[,] randomArray = new int[20, 20];
            for (firstValue = 0; firstValue < 20; firstValue++)
            {
                for (secondValue = 0; secondValue < 20; secondValue++)
                {
                    randomArray[firstValue, secondValue] = randomNumber.Next(minNumber, maxNumber);
                }
            }
            Console.WriteLine("Массив чисел 20x20 готов:");
            foreach (var item in randomArray)
            {
                Console.Write(item.ToString() + ", ");
            }
        }
    }
}
