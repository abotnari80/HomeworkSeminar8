int[,] array = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(1, 20);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}
int sum1 = 0; int sum2 = 0; int sum3 = 0;


for (int j = 0; j < 4; j++)
{
    sum1 = array[0, j] + sum1;
    sum2 = array[1, j] + sum2;
    sum3 = array[2, j] + sum3;
}
if (sum1 < sum2 && sum1 < sum3)
System.Console.WriteLine("1 строка");
else if (sum2 < sum1 && sum2 < sum3)
System.Console.WriteLine("2 строка");
else System.Console.WriteLine("3 строка");