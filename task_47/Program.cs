bool IsValid(int row, int colums)
{
    if (row > 0 && colums >0)return true;
    else return false;
}

int Input(string msg)
{
    Console.Write(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}

double[,] FillArray(int row, int colums, int min, int max)
{
    double[,] arr = new double[row,colums];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        }
    }
    return arr;
}

void PtintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + ": ");
        }
        Console.WriteLine();
    }
}

int row = Input("Введите количество строк массива row=");
int colums = Input("Введите количество столбцов массива colums=");
int min = Input("Введите начало диапазона min=");
int max = Input("Введите окончание диапазона max=");
if (IsValid(row, colums)) 
{
    double[,] Array = FillArray(row, colums, min, max);
    PtintArr(Array);
}
else Console.WriteLine("Не верные данные");
