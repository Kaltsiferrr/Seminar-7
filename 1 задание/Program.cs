double[,] RandomMass(int m, int n)
{
    double[,] mass = new double[m,n];
    for (int i = 0;i<m;i++)
    {
        for (int j = 0; j<n;j++)
        {
            mass[i,j] = new Random().NextDouble();
        }
    }
    return mass;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0);i++)
    {
        for (int j = 0; j < inArray.GetLength(1);j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
double[,] array = RandomMass(m,n);
PrintArray(array);
