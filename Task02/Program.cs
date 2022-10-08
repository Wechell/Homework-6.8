using System;
using System.Security.Cryptography.X509Certificates;

public class Mainclass
{
    public static void Main()
    {
        Console.Write("Введите количество строк ваших матриц: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов ваших матриц: ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        int[,] matrix1 = new int[n, m];
        
        Random rand = new Random();

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                int random = rand.Next(-10, 11);
                matrix1[i, j] = random;
                Console.Write($"{matrix1[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int[,] matrix2 = new int[n, m];

        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int random = rand.Next(-10, 11);
                matrix2[i, j] = random;
                Console.Write($"{matrix2[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int[,] matrix3 = new int[n, m];

        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write($"{matrix3[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}