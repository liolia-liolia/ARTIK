// ЗАДАЧА 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// if(num1 > num2)
// {
//     Console.WriteLine($"{num1} большее число, {num2} меньшее число.");
// }
// else
// {
//     Console.WriteLine($"{num2} большее число, {num1} меньшее число.");
// }
    
// ЗАДАЧА 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine()!);
// int max = num1;
// if(num2 > max) max = num2;
// if(num3 > max) max = num3;
// Console.WriteLine($"Максимальное число - {max}");

// ЗАДАЧА 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// if(num1 % 2 == 0)
// {
//     Console.WriteLine($"Да, число {num1} является четным.");
// }
// else
// {
//     Console.WriteLine($"Нет число {num1} не является четным.");
// }

// ЗАДАЧА 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int num1 = 1;
// while(num1 <= num)
// {
//     if(num1 % 2 == 0)
//     {
//         Console.Write($"{num1} ");
//     }
//    num1++;
// }