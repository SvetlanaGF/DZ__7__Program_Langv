// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет

Console.Clear();

int [,] array = { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4} };

void OutPutArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"   " + arr[i,j]);
        }
        Console.WriteLine();
    }
}
OutPutArray (array);

int countRow = array.GetLength(0);
int countColumn = array.GetLength(1);

Console.WriteLine("Введите позицию элемента массива:");
Console.Write("Строка: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбец: ");
int column = int.Parse(Console.ReadLine());

if (row > (countRow-1) | column > countColumn-1) 
{
    Console.WriteLine($"В массиве не существует элемента для указанной позиции - [" + row + ", " + column + "]");
}
else
{
    Console.WriteLine($"Элемент массива = " + array[row,column]);
}