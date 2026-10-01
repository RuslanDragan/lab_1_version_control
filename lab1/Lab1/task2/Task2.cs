using System;

namespace Lab1_Task2_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування для коректного відображення українських символів
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int n = 130;
            int[] array = new int[n];
            Random rand = new Random();

            // 1. Заповнення масиву випадковими числами в діапазоні від 0 до 100
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, 101); // Верхня межа у Random.Next не включається, тому 101
            }

            Console.WriteLine($"=== Аналіз масиву з {n} елементів (діапазон 0-100) ===");
            
            // Виведемо перші 20 елементів для наочності
            Console.Write("Перші 20 елементів масиву: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("...\n");

            // 2. Підрахунок кількості ділянок із неспадними значеннями
            int segmentsCount = 0;
            
            if (n > 0)
            {
                segmentsCount = 1; // Починаємо з першої ділянки
                
                for (int i = 0; i < n - 1; i++)
                {
                    // Якщо умова неспадання порушується (елемент більший за наступний),
                    // це означає, що поточна неперервна ділянка закінчилася.
                    if (array[i] > array[i + 1])
                    {
                        segmentsCount++;
                    }
                }
            }

            // 3. Виведення результату
            Console.WriteLine($"Кількість неперервних ділянок із неспадними значеннями: {segmentsCount}");

            // Затримка закриття консолі
            Console.WriteLine("\nДля завершення натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}