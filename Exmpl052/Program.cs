// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] array = { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4} };
int countRow = array.GetLength(0);

int countColumn = array.GetLength(1);

double SummColumn (int [,] arr, ref int j)
{
double resultSum = 0;
for (int i=0; i < countRow; i++)
{
	resultSum = resultSum + arr [i,j];
}
    return resultSum / countRow;
}

double average = 0;
for (int j=0; j < countColumn; j++)
{
    average = SummColumn (array, ref j);
    Console.WriteLine("Среднее арифметическое столбца {1} = {0:f2}", average, j);
}

