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
System.Console.WriteLine("Задача 19. Напишите програму, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
System.Console.Write("Введите пятизначное число: ");
int drom1 = int.Parse(Console.ReadLine()!);
string StrNum = drom1.ToString();
if (StrNum.Length == 5)
{
    if (StrNum[0] == StrNum[4] && StrNum[1] == StrNum[3])
    {
        System.Console.WriteLine("Это палиндром!");
    }
    else
    {
        System.Console.WriteLine("Это не палиндром!");
    }
}
else
{
    System.Console.WriteLine("Введено неверное число!");
}




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

// // Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// System.Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N");
// System.Console.Write("Введите натуральное число: ");
// int N = int.Parse(Console.ReadLine()!);
// for(int i = 1; i <= N; i++)
// {
//     System.Console.Write(Math.Pow(i, 3) + " ");
// }