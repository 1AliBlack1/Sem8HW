//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] Created2dArray(int row, int collumn, int minVal, int maxVal)
{
    int[,] createdArray = new int [row, collumn];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < collumn; j++)
            createdArray [i,j] = new Random().Next(minVal, maxVal +1);
    return createdArray;        
}

void Show2dArray(int [,] arrayToShow)
{
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            Console.Write(arrayToShow[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();     
}


int[,] MaxToMin(int [,] arrayToChange)
{
    for (int i = 0; i < arrayToChange.GetLength(0); i++)
        for(int j = 0; j < arrayToChange.GetLength(1); j++)
            for(int k = 0; k < arrayToChange.GetLength(1)-1; k++)
            if(arrayToChange[i,k]< arrayToChange[i,k +1])
            {
                int temp = arrayToChange[i,k+1];
                arrayToChange[i,k+1] = arrayToChange[i,k];
                arrayToChange[i,k] = temp;
            }    
    return arrayToChange;        
}

int[,] startArray = Created2dArray(5,6,1,9);
Show2dArray(startArray);
Show2dArray(MaxToMin(startArray));


//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
   int i,j;
   Random rand = new Random();
   for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
          randomArray[i,j] = rand.Next(1,9);
        }
    }    
}

void printm(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
             Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

mas(m,n);
Console.WriteLine("Исходный массив: ");
printm(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    if (sum > SumLine(randomArray, i))
    {
        sum = SumLine(randomArray, i);
        minSum = i+1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

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

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] Create3dArray(int rows, int collumns, int deep, int minVal, int maxVal)
{
    int[,,] crt3dArray = new int [rows, collumns, deep];
    Random rnd = new Random();
    for(int i = 0; i < crt3dArray.GetLength(0); i++)
        for(int j = 0; j < crt3dArray.GetLength(1); j++)
            for(int k = 0; k < crt3dArray.GetLength(2); k++)
                {
                    crt3dArray[i,j,k] = rnd.Next(minVal, maxVal +1);
                }
    return crt3dArray;
}

void Show3dArray(int[,,] array3d)
{
    for(int i = 0; i < array3d.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i,j,k]}({i},{j},{k})| ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] array3D = Create3dArray(2,2,2,1,10);
Show3dArray(array3D);

//Напишите программу, которая заполнит спирально массив 4 на 4

int n = 5;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

