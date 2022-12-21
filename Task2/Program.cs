void Random(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[m,n];
Random(table);
Console.WriteLine("-------------------------");

int SumElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int minSumLine = 0;
int sumLine = SumElements(table, 0);
for (int i = 1; i < table.GetLength(0); i++)
{
  int tempSumLine = SumElements(table, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"{minSumLine+1} строка c наименьшей суммой элементов - {sumLine}");