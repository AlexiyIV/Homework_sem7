bool IsValid(int rows, int colums)
{
    if (rows > 0 && colums > 0) return true;
    else return false;
}

int Input(string msg)
{
    Console.Write(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int[,] FillArray(int rows, int colums, int min, int max)
{
    int[,] arr = new int[rows, colums];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

double[] ArrayArithmeticMean(int[,] arr)
{
    double[] array = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += (double)arr[i, j];
        }
        array[j] = Math.Round(sum / arr.GetLength(0),2);
    }
    return array;
}

void PrintArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray1(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine();
}

int rows = Input("Введите количество строк массива rows=");
int colums = Input("Введите количество стобцов массива colums=");
int min = Input("Введите начало диапазона min=");
int max = Input("Введите конец диапазона max=");
if (IsValid(rows, colums))
{
    int[,] Array = FillArray(rows, colums, min, max);
    double[] arithmeticMeanArray = ArrayArithmeticMean(Array);
    PrintArray2(Array);
    PrintArray1(arithmeticMeanArray);
}
else Console.WriteLine("Неверные данные");

