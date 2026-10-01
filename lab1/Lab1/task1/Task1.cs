using System;

namespace Lab1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування для коректного відображення українських символів у консолі
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Пошук рядкового фрагмента в масиві рядків ===");
            
            // 1. Введення кількості елементів масиву
            Console.Write("Введіть кількість рядків у масиві: ");
            int n = int.Parse(Console.ReadLine());

            string[] stringsArray = new string[n];

            // 2. Введення елементів масиву з клавіатури
            Console.WriteLine("Введіть елементи масиву (рядки):");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Рядок [{i + 1}]: ");
                stringsArray[i] = Console.ReadLine();
            }

            // 3. Введення шуканого фрагмента
            Console.Write("\nВведіть рядковий фрагмент для пошуку: ");
            string findThisString = Console.ReadLine();

            // 4. Пошук та виведення результатів
            Console.WriteLine("\n--- Результати пошуку ---");
            bool foundAny = false;

            for (int i = 0; i < stringsArray.Length; i++)
            {
                // Використовуємо метод IndexOf для пошуку підрядка
                int index = stringsArray[i].IndexOf(findThisString);

                if (index != -1)
                {
                    Console.WriteLine($"Знайдено у рядку [{i + 1}] \"{stringsArray[i]}\": позиція початку збігу = {index}");
                    foundAny = true;
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("Жоден рядок не містить заданий фрагмент.");
            }

            // Затримка закриття консолі
            Console.WriteLine("\nДля завершення натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}