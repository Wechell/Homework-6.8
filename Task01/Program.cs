using System;
using System.Security.Cryptography.X509Certificates;

public class Mainclass
{
    public static void Main()
    {
        Console.Write("Введите количество строк в вашей будущей матрице: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в вашей будущей матрице: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, m];
        int counter = 0;

        Random rand = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int random = rand.Next(0, 100);
                matrix[i, j] = random;
                counter += random;
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Сумма элементов матрицы = {counter}");
    }
}