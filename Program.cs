/*Задача:
На входе функция получает параметр n - натуральное число. Необходимо сгенерировать n-массивов, 
заполнить их случайными числами, каждый массив имеет случайный размер. Размеры массивов не должны совпадать. 
Далее необходимо отсортировать массивы. Массивы с четным порядковым номером отсортировать по возрастанию, 
с нечетным порядковым номером - по убыванию. На выходе функция должна вернуть массив с отсортированными массивами.*/


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = 5; // можно заменить на желаемое количество массивов
        int[][] sortedArrays = GenerateAndSortArrays(n);

        // вывод отсортированных массивов
        for (int i = 0; i < sortedArrays.Length; i++)
        {
            Console.Write($"Массив {i + 1}: ");
            foreach (int num in sortedArrays[i])
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    static int[][] GenerateAndSortArrays(int n)
    {
        Random rand = new Random();
        int[][] arrays = new int[n][];

        for (int i = 0; i < n; i++)
        {
            int size = rand.Next(1, 11); // генерируем случайный размер массива от 1 до 10
            arrays[i] = new int[size];

            for (int j = 0; j < size; j++)
            {
                arrays[i][j] = rand.Next(1, 101); // заполняем массив случайными числами от 1 до 100
            }
        }

        // сортировка массивов с четным порядковым номером по возрастанию,
        // а с нечетным порядковым номером - по убыванию
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                Array.Sort(arrays[i]);
            }
            else
            {
                Array.Sort(arrays[i], (a, b) => b.CompareTo(a));
            }
        }

        return arrays;
    }
}
