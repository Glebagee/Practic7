using System;

class Program
{
    static void Main()
    {
        int[] array1 = { 5, 3, 8, 1, 2 };
        int[] array2 = { 4, 6, 7, 9, 0 };

        // Сортировка массива по возрастанию
        Console.WriteLine("Исходный массив (возрастание):");
        PrintArray(array1);
        SortArrayAscending(array1);
        Console.WriteLine("Отсортированный массив (возрастание):");
        PrintArray(array1);

        // Сортировка массива по убыванию
        Console.WriteLine("\nИсходный массив (убывание):");
        PrintArray(array2);
        SortArrayDescending(array2);
        Console.WriteLine("Отсортированный массив (убывание):");
        PrintArray(array2);

        // Объединение двух массивов
        int[] combinedArray = CombineArrays(array1, array2);
        Console.WriteLine("\nОбъединенный массив:");
        PrintArray(combinedArray);
    }

    // Метод сортировки массива по возрастанию
    static void SortArrayAscending(int[] array)
    {
        Array.Sort(array);
    }

    // Метод сортировки массива по убыванию
    static void SortArrayDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
    }

    // Метод объединения двух массивов в один
    static int[] CombineArrays(int[] array1, int[] array2)
    {
        int[] combinedArray = new int[array1.Length + array2.Length];
        Array.Copy(array1, combinedArray, array1.Length);
        Array.Copy(array2, 0, combinedArray, array1.Length, array2.Length);
        return combinedArray;
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}