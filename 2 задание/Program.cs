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
void FindPos(int x,int y)
{
    if (x<mass.Length && y<mass.Length)
    {
    Console.WriteLine($"В ячейке {x},{y}  находится число {mass[x,y]}");
    }
    else Console.WriteLine("Данного элемента нет.");
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
Console.Clear();
Console.WriteLine("Введите номер строки массива: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца массива: ");
int y = int.Parse(Console.ReadLine());
int[,] array = RandomMass();
FindPos(x,y);
PrintArray(mass);
