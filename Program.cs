
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
/*
int[,] RandomArray (int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void SortArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + array[i, j] + " ");
        Console.Write("\n");
    }
}

void SortRow (int[,] array, int Index)
{
    for(int i = 0; i < array.GetLength(1); i++)
        for(int j = i; j < array.GetLength(1); j++)
            if(array[Index, j] > array[Index, i])
                {
                    int temp = array[Index, j];
                    array [Index, j] = array[Index, i];
                    array[Index, i] = temp;
                }
}

Console.Write("Input row count: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column count: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = RandomArray(rows, cols, min, max);
Console.WriteLine("Initial array:");
SortArray(NewArray);

for(int i = 0; i < NewArray.GetLength(0); i++)
    SortRow(NewArray, i);

Console.WriteLine("\nSorted rows array:");
SortArray(NewArray);
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
/*
int InputNumbers(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}

void RandomArray(int[,] array)
{
Console.WriteLine("Input random numbers:");
int range = InputNumbers("input: 1 to ");
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(range);
}
}
}

void WriteArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i,j] + " ");
}
Console.WriteLine();
}
}

int SumLineNum(int[,] array, int i)
{
int sumLine = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sumLine += array[i,j];
}
return sumLine;
}

Console.WriteLine("Input m x n :");
int m = InputNumbers("Input m: ");
int n = InputNumbers("Input n: ");
int[,] array = new int[m, n];
RandomArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineNum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
int tempSumLine = SumLineNum(array, i);
if (sumLine > tempSumLine)
{
sumLine = tempSumLine;
minSumLine = i;
}
}
Console.WriteLine($"\n{minSumLine+1} - this is min sum ({sumLine})  ");
*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int m = InputNumbers("Enter row count matrix 1: ");
int n = InputNumbers("Enter column count matrix 1: ");
int p = InputNumbers("Enter column count matrix 2: ");
int range = InputNumbers("input: 1 to  ");

int InputNumbers(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}

void CreateArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(range);
}
}
}

void WriteArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i,j] + " ");
}
Console.WriteLine();
}
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
for (int j = 0; j < resultMatrix.GetLength(1); j++)
{
int sum = 0;
for (int k = 0; k < firstMartrix.GetLength(1); k++)
{
sum += firstMartrix[i,k] * secomdMartrix[k,j];
}
resultMatrix[i,j] = sum;
}
}
}

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"First matrix:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Second matrix:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Result of two matrices:");
WriteArray(resultMatrix);
/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
/*
int InputNumbers(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}

int[,,] CreateRandomArray()
{
int rows = InputNumbers("Input quantity rows: ");
int columns = InputNumbers("Input quantity columns: ");
int depth = InputNumbers("Input quantity depth: ");
int minValue = InputNumbers("Input minValue: ");
int maxValue = InputNumbers("Input maxValue: ");

int[,,] matrix = new int[rows, columns, depth];
for (int i = 0; i < matrix.GetLength(0); i++) 
{ 
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int k = 0; k < matrix.GetLength(2); k++) 
{ 
matrix[i,j,k] = new Random().Next(minValue, maxValue + 1);
}
} 
}
return matrix; 
}

void PrintMatrix(int[,,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++) 
{
for (int k = 0; k < matrix.GetLength(2); k++)
{
Console.Write($" {matrix[i, j, k]} {(i,j,k)} "); 
}
Console.WriteLine();
} 
} 
Console.WriteLine(); 
}

int[,,] CreateArray(int[,,] array3D)
{
int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
int number;
for (int i = 0; i < temp.GetLength(0); i++)
{
temp[i] = new Random().Next(1, 10);
number = temp[i];
if (i >= 1)
{
for (int j = 0; j < i; j++)
{
while (temp[i] == temp[j])
{
temp[i] = new Random().Next(1,10);
number = temp[i];
}
number = temp[i];
}
}
}
int count = 0; 
for (int x = 0; x < array3D.GetLength(0); x++)
{
for (int y = 0; y < array3D.GetLength(1); y++)
{
for (int z = 0; z < array3D.GetLength(2); z++)
{
array3D[x, y, z] = temp[count];
count++;
}
}
}
return array3D;
}

int[,,] array3D = CreateRandomArray();
PrintMatrix(array3D);
Console.WriteLine();
int[,,]unicumNumbergArray =CreateArray(array3D);
PrintMatrix(unicumNumbergArray);
*/
//Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("\n Input 4  \n");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
nums[i, j] = num;
if (i <= j + 1 && i + j < size - 1)
++j;
else if (i < j && i + j >= size - 1)
++i;
else if (i >= j && i + j > size - 1)
--j;
else
--i;
++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
Console.Write("[ ");
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.Write("]");
Console.WriteLine("");
}
}