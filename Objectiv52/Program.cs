Console.Write("Введите размер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер ряда: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив: ");
int[,] matrix = new int[colums, rows];
GetArrayFillRandomNumbers(matrix);
WriteArray(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i,j]);
    }
    avarage = avarage / colums;
    Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {avarage + ";"}");
}
Console.WriteLine();

void GetArrayFillRandomNumbers( int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-100, 100)/10;
    }
}
}

void WriteArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
}


