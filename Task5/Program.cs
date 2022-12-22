Console.Clear();
int[,] matrix = new int[4, 4];

void Array(int[,] array, int n)
{
    int i = 0, j = 0;
    int cons = 1;
    for (int z = 0; z < n * n; z++)
    {
        int k = 0;
        do { array[i, j++] = cons++; } 
        while (++k < n - 1);
            for (k = 0; k < n - 1; k++) 
                array[i++, j] = cons++;
                    for (k = 0; k < n - 1; k++) 
                        array[i, j--] = cons++;
                            for (k = 0; k < n - 1; k++) 
                                array[i--, j] = cons++;
                                i++; j++;
                                n = n < 2 ? 0 : n - 2;
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Array(matrix, 4);
WriteArray(matrix);