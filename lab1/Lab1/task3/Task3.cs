using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування для коректного відображення українських символів
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Обчислення коренів квадратного рівняння (ax^2 + bx + c = 0) ===");

            // 1. Введення коефіцієнтів a, b, c з клавіатури з використанням Convert.ToDouble та Console.ReadLine
            Console.Write("Введіть коефіцієнт a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть коефіцієнт b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть коефіцієнт c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Перевірка, чи є рівняння квадратним (a не повинно дорівнювати 0)
            if (a == 0)
            {
                Console.WriteLine("\nПомилка: коефіцієнт 'a' не може дорівнювати 0 (це не квадратне рівняння).");
            }
            else
            {
                // 2. Обчислення дискримінанта: D = b^2 - 4ac
                double discriminant = (b * b) - (4 * a * c);
                Console.WriteLine($"\nДискримінант (D) = {discriminant}");

                // 3. Аналіз дискримінанта та пошук коренів
                if (discriminant > 0)
                {
                    // Два дійсні різні корені
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("Рівняння має два дійсні корені:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
                else if (discriminant == 0)
                {
                    // Один дійсний корінь (або два співпадаючі)
                    double x = -b / (2 * a);

                    Console.WriteLine("Рівняння має один дійсний корінь:");
                    Console.WriteLine($"x = {x}");
                }
                else
                {
                    // Від'ємний дискримінант — дійсних коренів немає (або є комплексні)
                    Console.WriteLine("Дискримінант менший за нуль. Рівняння не має дійсних коренів у множині дійсних чисел.");
                }
            }

            // Затримка закриття консолі
            Console.WriteLine("\nДля завершення натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}