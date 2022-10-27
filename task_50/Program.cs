// Задача 50.  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// программа написана с учётом того, что строка и столбец будет задаваться пользвателем,
// то есть заданная строка 1 и столбец 1 будут иметь значение элемента с индексами 0, 0

bool IsValid(int rows,int colums)
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
		for (int j = 0; j< arr.GetLength(1); j++)
		{
			arr[i,j] = new Random().Next(min, max);
		}
	}
	return arr;
}

void PrintArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write(arr[i,j] + "; ");
		}
		Console.WriteLine();
	}
}


int rows = Input("Введите количество строк массива rows=");
int colums = Input("Введите количество столбцов массива colums=");
int min = Input("Введите начало диапазона min=");
int max = Input("Введите конец диапазона max =");
if (IsValid(rows, colums))
{
	int[,] Array = FillArray(rows, colums, min, max);
	PrintArray(Array);
	int row = Input("Введите номер строки row=");
	int colum = Input("Введите номер столбца colum=");
	if (row > 0 && row <= rows && colum >0 && colum <= colums) 
		Console.WriteLine("Элемент на строке " + row + ", в столбце " + colum + "=" + Array[row-1,colum-1]);
	else Console.WriteLine("Элемента с такими координатами нет");
}
else Console.WriteLine("Неверные данные");


