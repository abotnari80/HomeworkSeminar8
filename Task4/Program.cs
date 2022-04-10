int[,] mass = new int[4, 4];
int value = 1;

for (int j = 0; j < 4; j++)
{
    int i = 0;
    mass[i, j] = value;
    value++;
}

for (int i = 1; i < 4; i++)
{
    int j = 3;
    mass[i, j] = value;
    value++;
}

for (int j = 2; j >= 0; j--)
{
    int i = 3;
    mass[i, j] = value;
    value++;
}

for (int i = 2; i > 0; i--)
{
    int j = 0;
    mass[i, j] = value;
    value++;
}

for (int j = 1; j < 3; j++)
{
    int i = 1;
    mass[i, j] = value;
    value++;
}

for (int i = 2; i < 3; i++)
{
    int j = 2;
    mass[i, j] = value;
    value++;
}

for (int j = 1; j > 0; j--)
{
    int i = 2;
    mass[i, j] = value;
    value++;
}

for (int ii = 0; ii < 4; ii++)
{
    for (int jj = 0; jj < 4; jj++)
    {
        System.Console.Write(mass[ii, jj] + "  ");
    }
    System.Console.WriteLine();
}