using System;
using System.Security.Cryptography.X509Certificates;

public class Mainclass
{
    static int[,] Matrix(int a, int b)
    {
        Random random = new Random();
        int[,] matrix = new int[a, b];

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                int rand = random.Next(-10, 11);
                matrix[i, j] = rand;
            }
        }
        return matrix;
    }

    public static void Main()
    {
        Console.Write("Введите количество строк ваших матриц: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов ваших матриц: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = Matrix(n, m);
        int[,] matrix2 = Matrix(n, m);
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