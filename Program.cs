// Задача 1. Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 > num2)
    Console.WriteLine($"Число {num1} является большим, число {num2} является меньшим");
if(num2 > num1)
    Console.WriteLine($"Число {num2} является большим, число {num1} является меньшим");

// Задача 2.Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Максимальным из трех чисел является число {max}");

// Задача 3. Напишите программу, которая на вход принимает число и выдает,
// является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number % 2 == 0)
    Console.WriteLine($"Число {number} является чётным");
else
{
    Console.WriteLine($"Число {number} не является чётным");
}

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все четные числа от 1 до N
Console.WriteLine("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine()!);
int N1 = 1;
while(N1 <= N){
    if(N1 % 2 == 0){
        Console.Write($"{N1}, ");
    }
    N1++;
}