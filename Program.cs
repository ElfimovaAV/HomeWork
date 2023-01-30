// Задача 1. Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.
// Console.WriteLine("Задача 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.");
// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// if(num1 > num2)
//     Console.WriteLine($"Число {num1} является большим, число {num2} является меньшим");
// else
// {
//     if(num2 > num1)
//         Console.WriteLine($"Число {num2} является большим, число {num1} является меньшим");
//     else
//         Console.WriteLine($"Число {num1} равно числу {num2}");
// }


// Задача 2.Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел
// Console.WriteLine("Задача 2.Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел");
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);
// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine($"Максимальным из трех чисел является число {max}");

// Задача 3. Напишите программу, которая на вход принимает число и выдает,
// является ли число чётным (делится ли оно на два без остатка)
// Console.WriteLine("Задача 3. Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка).")
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if(number % 2 == 0)
//     Console.WriteLine($"Число {number} является чётным");
// else
// {
//     Console.WriteLine($"Число {number} не является чётным");
// }

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все четные числа от 1 до N
// Console.WriteLine("Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N");
// Console.WriteLine("Введите натуральное число: ");
// int N = int.Parse(Console.ReadLine()!);
// int N1 = 1;
// while(N1 <= N){
//     if(N1 % 2 == 0){
//         Console.Write($"{N1}, ");
//     }
//     N1++;
// }

// Задача 1. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа. Обязательная проверка на ввод чисел
// больше / меньше 3-х знаков.
// System.Console.WriteLine("Задача 1. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.");
// System.Console.Write("Введите трехзначное число: ");
// int M = int.Parse(Console.ReadLine()!);
// if(M > 99 && M < 1000)
// {
//     System.Console.WriteLine($"Вторая цифра числа {M}: {((M % 100)-(M % 10))/10}");
// }
// else
// {
//     System.Console.WriteLine($"Число {M} не является трехзначным");
// }

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Берем числа до 100000
// System.Console.WriteLine("Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
// System.Console.Write("Введите число: ");
// int L = int.Parse(Console.ReadLine()!);
// if(L < 100)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else if(L > 99 && L < 1000)
// {
//     System.Console.WriteLine($"Третья цифра числа {L}: {L % 10}");
// }
// else if(L > 999 && L < 10000)
// {
//     System.Console.WriteLine($"Третья цифра числа {L}: {((L % 100) - (L % 10))/10}");
// }
// else if(L > 9999 && L < 100000)
// {
//     System.Console.WriteLine($"Третья цифра числа {L}: {((L % 1000) - (L % 100))/100}");
// }

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа меньше 1 и больше 7.
// System.Console.WriteLine("Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
// System.Console.Write("Введите номер дня недели: ");
// int day = int.Parse(Console.ReadLine()!);
// if(day >= 1 && day <= 7)
// {
//     if(day == 6 || day == 7)
//     {
//         System.Console.WriteLine("Этот день выходной");
//     }
//     else
//     {
//         System.Console.WriteLine("Этот день не выходной");
//     }
// }
// else
// {
//     System.Console.WriteLine("Ошибка! Некорректный номер дня недели!");
// }

// Задача 19. Напишите програму, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// System.Console.WriteLine("Задача 19. Напишите програму, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
// System.Console.Write("Введите пятизначное число: ");
// int drom = int.Parse(Console.ReadLine()!);
// if(drom > 9999 && drom < 100000)
// {
//     if(drom/10000 == drom%10 && (drom/1000 - (drom/10000)*10) == ((drom%100 - drom%10)/10))
//     {
//         System.Console.WriteLine($"Число {drom} является палиндромом");
//     }
//     else
//     {
//         System.Console.WriteLine($"Число {drom} не является палиндромом");
//     }
// }
// else
// {
//     System.Console.WriteLine("Ошибка!Число должно содержать пять знаков");
// }

// Второй способ - через преобразование в строковый тип
// System.Console.WriteLine("Задача 19. Напишите програму, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
// System.Console.Write("Введите пятизначное число: ");
// int drom1 = int.Parse(Console.ReadLine()!);
// string StrNum = drom1.ToString();
// if (StrNum.Length == 5)
// {
//     if (StrNum[0] == StrNum[4] && StrNum[1] == StrNum[3])
//     {
//         System.Console.WriteLine("Это палиндром!");
//     }
//     else
//     {
//         System.Console.WriteLine("Это не палиндром!");
//     }
// }
// else
// {
//     System.Console.WriteLine("Введено неверное число!");
// }




// // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// System.Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");
// System.Console.Write("Введите координату X точки А: ");
// int x1 = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите координату Y точки А: ");
// int y1 = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите координату Z точки А: ");
// int z1 = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите координату X точки B: ");
// int x2 = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите координату Y точки B: ");
// int y2 = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите координату Z точки B: ");
// int z2 = int.Parse(Console.ReadLine()!);
// double dist = Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)), 2);
// System.Console.WriteLine($"Расстояние между точками A и B в 3D пространстве равно {dist}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// System.Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N");
// System.Console.Write("Введите натуральное число: ");
// int N = int.Parse(Console.ReadLine()!);
// for(int i = 1; i <= N; i++)
// {
//     System.Console.Write(Math.Pow(i, 3) + " ");
// }

// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// System.Console.WriteLine("Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
// System.Console.Write("Введите первое число: ");
// int A = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите второе число: ");
// int B = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Число {A} в степени {B} равно {GetDegree(A, B)}");

// // ---------------Методы-----------------
// int GetDegree (int n1, int n2)
// {
//     int degree = 1;
//     for(int count = 1; count <= n2; count++)
//     {
//         degree = degree * n1;
//     }
//     return degree;
// }

// Способ 2.
// System.Console.Write("Введите первое число: ");
// int A = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите второе число: ");
// int B = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Число {A} в степени {B} равно {Pow(A, B)}");

// // ---------------Методы-----------------
// int Pow (int num, int rank)
// {
//     if (rank == 0) return 1;
//     int result = num;
//     for(int i = 2; i <= rank; i++)
//     {
//         result *= num;
//     }
//     return result;
// }


// Задача 27. Написать программу, которая принимает на вход число и выдает сумму цифр в числе.
// System.Console.WriteLine("Задача 27. Написать программу, которая принимает на вход число и выдает сумму цифр в числе");
// System.Console.Write("Введите число: ");
// int F = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Сумма цифр в числе {F} равна {GetNumberSum(F)}");

// // ---------------Методы-----------------
// int GetNumberSum (int nmb)
// {
//     int sum = 0;
//     for (int n = nmb; n > 0; n = n / 10)
//     {
//         sum = sum + n % 10;
//     }
//     return sum;
// }

// Задача 29. Напишите программу, которая задаёт массив из 8 любых элементов и выводит их на экран
// System.Console.WriteLine("Задача 29. Напишите программу, которая задаёт массив из 8 любых элементов и выводит их на экран");
// int[] Array = GetArray(8);
// System.Console.WriteLine($"[{String.Join(";", Array)}]");


// // ----------Метод----------
// int[] GetArray (int size)
// {
//     int[] result = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0, 1000);
//     }
//     return result;
// }

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
// int[] arr4 = GetArray(10);
// System.Console.WriteLine($"[{String.Join(", ", arr4)}]");
// System.Console.WriteLine($"Количество четных чисел в массиве равно {GetCountPositive(arr4)}");

// // -----------Методы------------
// int[] GetArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int GetCountPositive(int[] array)
// {
//     int count = 0;
//     for(int i = 1; i < array.Length; i++)
//     {
//         if(array[i]%2 == 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

//  Способ 2 прописать метод подсчета четных чисел
// int GetCountPositive(int[] array)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if(item % 2 == 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

// System.Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.");
// int[] arr5 = GetArray2(10);
// System.Console.WriteLine($"[{String.Join(", ", arr5)}]");
// System.Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах равна {GetSumOddElements(arr5)}");

// // -----------Методы------------
// int[] GetArray2(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 10001);
//     }
//     return array;
// }

// int GetSumOddElements(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(i%2 > 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// // [1 2 3 4 5] -> 5 8 3

// // [6 7 3 6] -> 36 21

// System.Console.WriteLine("Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
// int[] arr6 = GetArray3(6);
// System.Console.WriteLine($"[{String.Join(", ", arr6)}]");
// System.Console.WriteLine($"[{String.Join(", ", GetProduct(arr6))}]");



//---------Методы-------------
// int[] GetArray3(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 1001);
//     }
//     return array;
// }

// int[] GetProduct (int[] array)
// {
//     double N = array.Length;
//     double R = Math.Round(N / 2, MidpointRounding.AwayFromZero);
//     int N1 = Convert.ToInt32(N);
//     int R1 = Convert.ToInt32(R);
//     int[] array2 = new int[R1];
//     for(int i = 0; i < R1; i++)
//     {
//         if(i != (N1 - i - 1))
//         {
//             array2[i] = array[i] * array[N1 - i - 1];
//         }
//         else
//         {
//             array2[i] = array[i];
//         }
//     }
//     return array2;
// }
// Способ 2 наполнения массива
// int[] GetProduct (int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1)
//     {
//         size ++;
//     }
//     int[] array2 = new int[size];
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         array2[i] = array[i] * array[array.Length - i - 1];
//     }
//     if (array.Length % 2 == 1)
//     {
//         array2[size - 1] = array[array.Length / 2];
//     }
//     return array2;
// }
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries) 
// (пользователь вводит в консоли числа через пробел и они формируют строку)

// System.Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.");
// System.Console.Write("Введите несколько чисел через пробел: ");
// string numbers = Console.ReadLine()!;
// FindEven (numbers);

// // -----Методы---------
// void FindEven (string input)
// {
//     string[] array = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (Convert.ToInt32(Convert.ToString(array[i])) > 0)
//         {
//          count ++;
//         }
//     }
//     System.Console.WriteLine($"Количество чисел больше нуля {count}");
// }

// Получение массива из строки
// int[] GetArrayFromString (string text)
// {
//     string[] nums = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[nums.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = int.Parse(nums[i]);
//     }
//     return result;
// }

// //  Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
// //  (не менее 6) в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// //  но отсортированный по возрастанию(от меньшего числа к большему).

// System.Console.WriteLine("Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6) в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).");
// int[] arr = GetArray2(10, 0, 100);
// System.Console.WriteLine($"[{String.Join(",", arr)}]");
// SortingArray (arr);



// // -----------Методы------------
// int[] GetArray2(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

//  void SortingArray (int[] array)
// {
// 	for (int i = 0; i < array.Length; i++)
// 		{
//             for (int j = 0; j < array.Length - 1; j++)
// 			{
//                 if (array[j] > array[j + 1])
// 					{
// 						int temp = array[j + 1];
// 						array[j + 1] = array[j];
// 						array[j] = temp;
// 					}
// 		    }
//         }
//     System.Console.WriteLine($"[{String.Join(",", array)}]");
// }

//  еще один вариант кода сортировки
//  void SortArray (int[] array)
// {
// 	for (int i = 0; i < array.Length - 1; i++)
// 		{
//             for (int j = i + 1; j < array.Length; j++)
// 			{
//                 if (array[i] > array[j])
// 					{
// 						int temp = array[i];
// 						array[i] = array[j];
// 						array[j] = temp;
// 					}
// 		    }
//         }
//     System.Console.WriteLine($"[{String.Join(",", array)}]");
// }

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");
// System.Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, -1000, 1000);
// PrintArray(array);


// // -----------------Методы----------------
// double[,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Random element = new Random();
//             for (int k = minValue; k <= maxValue; k++) 
//             {
//                 result[i,j] = Math.Round((Convert.ToDouble(element.Next(minValue, maxValue + 1)))/100, 1);
//             }
//          }
//     }
//     return result;
// }

// void PrintArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// способ 2
// double[,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().NextDouble()*(maxValue - minValue);
//          }
//     }
//     return result;
// }

// Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// System.Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.");
// System.Console.Write("Введите количество строк: ");
// int rows2 = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите количество столбцов: ");
// int columns2 = int.Parse(Console.ReadLine()!);

// int[,] array2 = GetArray2(rows2, columns2, 0, 100);
// PrintArray2(array2);

// System.Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// if (FindElement (array2, number))
// {
//     System.Console.WriteLine("Элемент найден");
// }
// else
// {
//     System.Console.WriteLine("Элемент не найден");
// }

// -----------------Методы----------------
// int[,] GetArray2 (int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray2 (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// bool FindElement (int[,] array, int Find)
// {
//     foreach(int elem in array)
// {
//     if(elem == Find)
//     {
//         return true;
//     }
// }
// return false;
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
// System.Console.Write("Введите количество строк: ");
// int rows3 = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите количество столбцов: ");
// int columns3 = int.Parse(Console.ReadLine()!);

// int[,] array3 = GetArray2(rows3, columns3, 0, 100);
// PrintArray2(array3);
// System.Console.WriteLine();
 
// System.Console.Write(string.Join(", ",MiddleSum(array3)));


// --------------Методы---------------
// double[] MiddleSum (int[,] array)
// {
//     double[] result = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         int count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i,j];
//             count ++;
//         }
//         result[j] = Math.Round((sum / count), 1);
//     }
//     return result;
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

SortArray(array);
PrintArray(array);

// -----------------Методы----------------
int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void SortArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0) - 1; k++)
		{
            for (int h = k + 1; h < array.GetLength(0); h++)
			{
                if (array[i,k] < array[i,h])
					{
						int temp = array[i,k];
						array[i,k] = array[i,h];
						array[i,h] = temp;
					}
		    }
        }
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

Console.WriteLine("Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.Write("Введите количество строк: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array2);
Console.WriteLine();

int[] SumArray = FindSumOfRows(array2);
Console.WriteLine($"[{String.Join(", ", SumArray)}]");
IndexOfMinSum(SumArray);

// // --------Методы-----------
int[] FindSumOfRows (int[,] array)
{
    int sum = 0;
    int[] massive = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        massive[i] = sum;
        sum = 0;
    }
    return massive;
}

void IndexOfMinSum (int[] massive)
{
    int min = massive[0];
    int minInd = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i] < min)
        {
            min = massive[i];
            minInd = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {minInd+1} строке");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
int column = row;

int[,] arrayA = GetArray(row, column, 0, 10);
PrintArray(arrayA);
Console.WriteLine();
int[,] arrayB = GetArray(row, column, 0, 10);
PrintArray(arrayB);
Console.WriteLine();

GetProductArray(arrayA, arrayB);

// // ----------Методы------------

void GetProductArray (int[,] FirstArray, int[,] SecondArray)
{
    if(FirstArray.GetLength(0) != SecondArray.GetLength(1) && FirstArray.GetLength(1) != SecondArray.GetLength(0))
    {
        Console.WriteLine($"Произведение вычислить нельзя");
    }
    int[,] result = new int[FirstArray.GetLength(0),SecondArray.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = 0;
            for (int k = 0; k < FirstArray.GetLength(1); k++)
            {
                result[i,j] += FirstArray[i,k] * SecondArray [k,j];
            }
        }
    }
    PrintArray(result);
}

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.Write("Введите количество строк: ");
int row_s = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int column_s = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество слоев: ");
int layers = int.Parse(Console.ReadLine()!);

int[,,] arra_y = GetMassive(row_s, column_s, layers, 0, 100);
PrintMassive(arra_y);
Console.WriteLine();

// // -----------------Методы----------------
int[,,] GetMassive (int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m,n,k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int h = 0; h < k; h++)
            {
                Random rand = new Random((int)DateTime.Now.Ticks);
                result[i,j,h] = rand.Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintMassive (int[,,] array)
{
    for (int h = 0; h < array.GetLength(2); h++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,h]}({i},{j},{h}) ");
            }
            Console.WriteLine();
        }
    }
}
