// Домашнее задание 1.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] RandomArray ( int rows, int columns)  
// {                                                                                
//     double[,] newArray = new double[rows,columns];                                     
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//            newArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());


// double[,] myArray = RandomArray(m,n);
// Show2DArray(myArray);

// Домашнее задание 2. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.Write("Введите индекс строки: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите индекс столбца: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

// int n = 3; 
// int m = 5; 
// Random random = new Random();

// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
// {
//     arr[i, j] = random.Next(10, 99);
// Console.Write("{0} ", arr[i, j]);
// }
// Console.WriteLine();
// }
//     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Такого элемента нет");
// }
//     else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }

// // Домашнее задание 3. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// 
// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
// {                                                                                
//     int[,] newArray = new int[rows,columns];                                     
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue+1); 
//         }
//     }
//     return newArray;
//     }
// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] ArraySum (int [,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
// }
// return array;
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// ArraySum(myArray);