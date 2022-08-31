Console.Write("Введите размер ряда: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив: ");
double[,] matrix = new double[colums, rows];
GetArrayFillRandomNumbers(matrix);
WriteArray(matrix);


void GetArrayFillRandomNumbers( double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
    }
}
}

void WriteArray(double[,] array)
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