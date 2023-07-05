
/* Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int numA = InputNum("Enter first integer number: ");
// int numB = InputNum("Enter second integer number: ");
// int result = 1;

// for (int i = 1; i <= numB; i++)

// {
//     result = result * numA;
// }

// Console.WriteLine($"{result}");


/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int num = InputNum("Enter integer number: ");

// int SumCount (int numX)
// {
//     int sum = 0;
//     while (numX > 10)
//     { 
//             sum = sum + numX % 10;
//             numX = numX / 10;
//     }
//     sum = sum + numX;
//     return sum;
// }

// int res = SumCount(num);
// Console.WriteLine(res);


/*
Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] InputArray()
{
    int[] EightArray = new int[8];
    Console.WriteLine("Enter 1st number: ");
    EightArray[0] = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 2nd number: ");
    EightArray[1] = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 3rd number: ");
    EightArray[2] = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 4th number: ");
    EightArray[3] = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 5th number: ");
    EightArray[4] = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 6th number: ");
    EightArray[5] = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 7th number: ");
    EightArray[6] = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 8th number: ");
    EightArray[7] = int.Parse(Console.ReadLine());
    return EightArray;
}

int[] array = InputArray();
Console.WriteLine($"[{array[0]}, {array[1]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");
