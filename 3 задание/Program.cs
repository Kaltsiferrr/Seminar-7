int[,] mass = new int[5,5];
int[,] RandomMass()
{
    for (int i = 0;i<5;i++)
    {
        for (int j = 0; j<5;j++)
        {
            mass[i,j] = new Random().Next(99);
        }
    }
    return mass;
}
void PrintArray(int[,] inArray)
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
void FindAverage()
{
    double sum=0;
    double Ave;
    for (int i = 0;i<5;i++)
    {
        for (int j = 0; j<5;j++)
        {
            sum += mass[i,j];
        }
        Ave = sum/mass.Length;
        Console.WriteLine($"Среднее арифметическое строки {i+1} равно {Ave}");
    }
}
Console.Clear();
RandomMass();
PrintArray(mass);
FindAverage();