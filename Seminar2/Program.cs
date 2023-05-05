//ЗАДАЧА 1: Напишите программу, которая принимает трёхзначное число и показывает вторую цифру этого числа.
//Обязательна проверка на ввод чисел больше/меньше 3-х знаков.

// Console.Write("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// if((num > 999)||(num < 100))
// {
//     Console.Write("Введите ТРЕХЗНАЧНОЕ число: ");
//     int num1 = int.Parse(Console.ReadLine()!);
//     int result1 = (num1 % 100) / 10;
//     Console.WriteLine($"Вторая цифра числа {num1} цифра {result1}.");
// }
// else
// {
//     int result = (num % 100) / 10;
//     Console.WriteLine($"Вторая цифра числа {num} цифра {result}.");
// }

//ЗАДАЧА 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Берем числа до 100000.

// Console.Write("Введите число от 100 до 99 999: ");
// int num = int.Parse(Console.ReadLine()!);
// if(num < 100)
// {
//     Console.WriteLine("Третьей цифры нет.");
// }
// if((num >= 100)&&(num <=999))
// {
//     int result = (num % 10);
//     Console.WriteLine($"Третья цифра числа {num} -> {result}.");
// }
// if((num >= 1000)&&(num <=9999))
// {
//     int result = (num % 100) / 10;
//     Console.WriteLine($"Третья цифра числа {num} -> {result}.");
// }
// if((num >= 10000)&&(num <=99999))
// {
//     int result = (num % 1000) / 100;
//     Console.WriteLine($"Третья цифра числа {num} -> {result}.");
// }
// if(num >= 100000)
// {
//     Console.WriteLine($"ПЕРЕБОР!");
// }

//ЗАДАЧА 3: Напишите программу, которая принимает на цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Обязательна проверка на ввод числа <1 и >7

// Console.Write("Введите цифру дня недели: ");
// int num = int.Parse(Console.ReadLine()!);
// if((num >= 1)&&(num <= 5))
// {
//     Console.WriteLine("Иди на работу.");
// }
// if((num == 6)||(num == 7))
// {
//     Console.WriteLine("Иди за пивом.");
// }
// if((num < 1)||(num > 7))
// {
//     Console.WriteLine("Иди в задницу.");
// }
