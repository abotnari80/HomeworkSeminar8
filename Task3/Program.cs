int[,,] mass = new int[2,2,2];
int x = 10; int y = 19;
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int n = 0; n < 2; n++)
        {
            mass[i,j,n] = new Random().Next(x,y);
            x = x + 10; y = y + 10;
            System.Console.Write($"{mass[i,j,n]}({i},{j},{n}) ");
        }
        System.Console.WriteLine();
    }
}
