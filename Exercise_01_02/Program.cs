/* Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет 
местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2 */ 



/* int rows = 3;
int columns = 4;


int[,] array = GetArray(rows, columns, 1, 10); 
PrintArray(array);
Console.WriteLine();

int[] array_null = new int[columns];

for(int i = 0; i < columns; i++)
{
    array_null[i] = array[0, i]; 
    array[0, i] = array[rows - 1, i];
    array[rows - 1, i] = array_null[i]; 
}

PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/ 




/* Задача 2: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7 */

int rows = 5;
int columns = 5;

int[,] array = GetArray(rows, columns, 1, 10); 
PrintArray(array);
Console.WriteLine();

int count = 0;
int number; 
if(rows == columns)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = count; j < array.GetLength(1); j++)
        {
            number = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = number;
        }
        count++;
    }
    PrintArray(array);  
}

else
{
    Console.WriteLine("Поменять строки со столбцами невозможно");
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}