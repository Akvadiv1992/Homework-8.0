Console.Clear();
int[,,] array3D = new int[2, 2, 2];

void CreateArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] += count;
                count ++;
            }
        }
    }
}

void WriteArray(int[,,] array)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Console.Write($"{array3D[i, j, z]}({i},{j},{z}) ");
            }
        }
    }
}
CreateArray(array3D);
WriteArray(array3D);