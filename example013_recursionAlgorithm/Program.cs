// string[,] table = new string[2,5];
// table[1,2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"{table[rows, columns]} -");
//     }
// }

void print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[7, 10];
print2DArray(matrix);
Console.WriteLine();
fill2DArray(matrix);
print2DArray(matrix);
System.Console.WriteLine();