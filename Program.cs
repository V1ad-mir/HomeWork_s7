// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Введите число столбцов:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число строк:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число интервала");
// int numFist = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число интервала");
// int numLast = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колиичество цифр после запятой(от 0 до 7)");
// int num2 = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     array[i, j] = Math.Round((new Random().Next(numFist, numLast + 1) + (new Random().NextDouble())), num2);
//     Console.Write(array[i, j] + "  ");
//   }
//   Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// double[,] inputAvtoArray(double[,] array)
// {
//   int numFist = new Random().Next(-10, 10);
//   int numLast = new Random().Next(10, 100);
//   int num2 = new Random().Next(0, 4);
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = Math.Round((new Random().Next(numFist, numLast + 1) + (new Random().NextDouble())), num2);
//       Console.Write(array[i, j] + "  ");
//     }
//     Console.WriteLine();
//   }
//   return array;
// }


// int[] vvodPosition(int[] array2, string[] position)
// {
//   for (int i = 0; i < position.Length; i++)
//   {
//     array2[i] = Convert.ToInt32(position[i]);
//   }
//   return array2;
// }


// int rows = new Random().Next(2, 10);
// int columns = new Random().Next(2, 10);
// double[,] array = new double[rows, columns];
// Console.WriteLine("Введите индекс элемента (индекс строки, пробел, индекс столбца)");
// string[] position = Console.ReadLine().Trim().Split(' ');
// if ((int.TryParse(position[0], out int num)))
// {
//   int lenghtArray2 = 0;
//   if (position.Length % 2 > 0)
//   {
//     lenghtArray2 = position.Length + 1;
//   }
//   else
//   {
//     lenghtArray2 = position.Length;
//   }
//   int[] array2 = new int[lenghtArray2];

//   vvodPosition(array2, position);

//   inputAvtoArray(array);
//   int j = 0;
//   while (j < array2.Length)
//   {
//     if ((array2[j] < array.GetLength(0)) && (array2[1 + j] < array.GetLength(1)))
//     {
//       Console.WriteLine("Элемент c индексом " + array2[j] + "," + array2[1 + j] + " равен " + array[array2[j], array2[1 + j]]);
//     }
//     else
//     {
//       Console.WriteLine("Элемент c индексом " + array2[j] + "," + array2[1 + j] + " отсутствует, введенная позиция за пределами массива");
//     }
//     j += 2;
//   }
// }
// else
// {
//   Console.Write("При вводе числа допущена ");
//   Console.ForegroundColor = ConsoleColor.Red;
//   Console.WriteLine("ОШИБКА");
//   Console.ResetColor();
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows,columns];
// double [] array2= new double [array.GetLength(1)];
// double sum=0;
// for (int i = 0; i < array.GetLength(0); i++)
// {  
//      for (int j = 0; j < array.GetLength(1); j++)
//    {
//       array[i,j]=new Random().Next(0,100);
//       Console.Write(array[i,j]+" ");
//    }
//    Console.WriteLine();
// }
// for (int j = 0; j < array.GetLength(1); j++)
// {  
//   sum=0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     sum=sum+array[i,j];
//   }
// array2[j]=Math.Round(sum/array.GetLength(1),3);
// }
// Console.WriteLine("Среднее арифметическое каждого столбца c округлением до тысячных: "+String.Join(";  ",array2));

//                           // Семинар
// // Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите число строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int sum=0;
int arrayLength=0;
int [,] array = new int [rows,columns];
if(rows>=columns)
{
   arrayLength=columns;
}
else
{
    arrayLength=rows;
}
int [] array2 = new int [arrayLength];
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().Next(0,10);

      if (i==j)
      {
         sum+=array[i,j];
         array2[j]=array[i,j];
      }
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}


//         //  Вариант вывода на семинаре
// Console.WriteLine("Сумма элементов  главной диагонали равна:"); 
// for (int i = 0; i < array2.Length; i++)
// {
//    Console.Write(array2[i]+"+");
// }
// Console.WriteLine("="+sum);




              // Вариант вывода 2
// Console.WriteLine("сумма чисел главной диагонали: ");

// Console.WriteLine(String.Join("+",array2)+"="+sum);


                // Вариант вывод 3
 Console.WriteLine("Сумма элементов  главной диагонали равна:");
for (int i = 0; i < array2.Length-1; i++)
{
   Console.Write(array2[i]+"+");
}
Console.WriteLine(array2[array2.Length-1]+"="+sum);

