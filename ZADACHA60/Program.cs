// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void CreateArray(int[,,] matrix3D)
{
    int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10, 100);
                j = 0;
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int m = 0; m < matrix3D.GetLength(0); m++)
    {
        for (int n = 0; n < matrix3D.GetLength(1); n++)
        {
            for (int p = 0; p < matrix3D.GetLength(2); p++)
            {
                matrix3D[m, n, p] = temp[count];
                count++;
            }
        }
    }
}

void WriteArray(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]} ({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число p:");
int p = Convert.ToInt32(Console.ReadLine());
int[,,] matrix3D = new int[m, n, p];
CreateArray(matrix3D);
WriteArray(matrix3D);