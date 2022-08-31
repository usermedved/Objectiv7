Console.Write("Введите позицию столбца: ");
int columsPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию ряда: ");
int rowsPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив: ");
int[,] matrix = new int[5, 5];
GetArrayFillRandomNumbers(matrix);
WriteArray(matrix);
int element = 0;

if (rowsPosition > matrix.GetLength(0) || columsPosition > matrix.GetLength(1))
{
    Console.WriteLine($"Такой позиции столбца {columsPosition} и позиции ряда {rowsPosition} нет !!!");
}
else
{
     element = matrix[rowsPosition - 1, columsPosition - 1];
     Console.WriteLine($"На позиции столбца {columsPosition} и позиции ряда {rowsPosition} стоит значение элемента {element}");
}
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