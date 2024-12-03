int[,] arr = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}};

for (int i = 0; i <= 2; i++)
{
    int sumOfRow = 0;
    for (int j = 0; j <= 2; j++)
    {
        sumOfRow += arr[i, j];
    }
    Console.WriteLine(sumOfRow);
}