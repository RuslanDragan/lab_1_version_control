using System;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування для коректного відображення українських символів
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Обчислення факторіала числа n ===");

            // 1. Введення значення n та перетворення на ціле число
            Console.Write("Введіть ціле невід'ємне число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // 2. Перевірка коректності введеного числа
            if (n < 0)
            {
                Console.WriteLine("Помилка: факторіал від'ємного числа не визначено.");
            }
            else
            {
                // Використовуємо тип long для зберігання результату (оскільки факторіал швидко зростає)
                long factorial = 1;

                // Обчислення факторіала за допомогою циклу for
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                // 3. Виведення результату на екран
                Console.WriteLine($"Факторіал числа {n} (n!) дорівнює: {factorial}");
            }

            // Затримка закриття консолі
            Console.WriteLine("\nДля завершення натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}