Console.Clear();
Console.WriteLine("Первая матрица:");
int[,] firstMartrix = new int[2, 2];
CreateArray(firstMartrix);
WriteArray(firstMartrix);
Console.WriteLine("Вторая матрица:");
int[,] secomdMartrix = new int[2, 2];
CreateArray(secomdMartrix);
WriteArray(secomdMartrix);

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]} \t");
    }
    Console.WriteLine();
  }
}
int n1 = firstMartrix[0,0] * secomdMartrix[0,0];
int n2 = firstMartrix[0,1] * secomdMartrix[0,1];
int n3 = firstMartrix[1,0] * secomdMartrix[1,0];
int n4 = firstMartrix[1,1] * secomdMartrix[1,1];
Console.WriteLine("Произведение чисел матрицы");
Console.Write($"{n1}\t");
Console.WriteLine(n2);
Console.Write($"{n3}\t");
Console.WriteLine(n4);