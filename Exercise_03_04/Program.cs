/* Задача 3: Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент. */ 

// СПОСОБ 1 (не очень рабочий)
// int[,] array = GetArray(4, 4, 1, 10); 
// PrintArray(array);
// Console.WriteLine();

// int[,] result = new int [4,4]; 

// int min = array [0, 0];
// int ii = 0;
// int jj = 0;

// for(int i = 0; i < array.GetLength(0); i++)
// {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         if(array[i, j] <= min)
//         {
//             min = array[i, j];
//             ii = i;
//             jj = j; 
//         }
//     }
// }
// Console.WriteLine($"Наименьший элемент массива = {min}");


// for(int i = 0; i < array.GetLength(0); i++)
// {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         if(ii != i && jj != j)
//         {
//             result[i, j] = array[i,j]; 
//         }
//         else
//         {
//             break; 
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(result); 



// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// СПОСОБ 2 (Николай)

int[,] array = GetArray(4, 4, 1, 10); 
PrintArray(array);
Console.WriteLine();

FindMinimalIndex(array, out int minItemRowIndex, out int minItemColoumnIndex);

array = RebuildArray(array, minItemRowIndex, minItemColoumnIndex);
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

void FindMinimalIndex(int[,] array, out int minItemRowIndex, out int minItemColoumnIndex)
{
    minItemRowIndex = 0;
    minItemColoumnIndex = 0;
    int minNumber = array[0, 0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                minItemRowIndex = i;
                minItemColoumnIndex = j;
            }
        }
    }
}


int [,] RebuildArray(int[,] array, int minItemRowIndex, int minItemColoumnIndex)
{
    int[,] NewArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for(int ai = 0, nai = 0; ai < array.GetLength(0); ai++)
    {
        if(ai == minItemRowIndex)
        {
            continue;
        }
        for(int aj = 0, naj = 0; aj < array.GetLength(1); aj++)
        {
            if(aj == minItemColoumnIndex)
            {
                continue;
            }
            NewArray[nai, naj] = array[ai, aj];
            naj++;
        }
        nai++; 
    }
    return NewArray;
}   

