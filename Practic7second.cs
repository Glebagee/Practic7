using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число n: ");

        // Попробуем считывать ввод и преобразовать его в целое число
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            // Рассчитываем абсолютную разность
            int absoluteDifference = Math.Abs(n - 123);

            // Проверяем, больше ли n, чем 123
            if (n > 123)
            {
                // Возвращаем тройную абсолютную разность
                absoluteDifference *= 3;
            }

            // Выводим результат
            Console.WriteLine($"Результат: {absoluteDifference}");
        }
        else
        {
            Console.WriteLine("Ошибка: Пожалуйста, введите корректное целое число.");
        }

    }
}