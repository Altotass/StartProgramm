// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Первое число      ");
Console.WriteLine("X:  ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число      ");
Console.WriteLine("Y:  ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z:  ");
int Z = Convert.ToInt32(Console.ReadLine());
int max = X;

if (Y  > X)
{
    max = Y;
}
if (Z  > max)
{
    max = Z;
}
Console.WriteLine("Самое большое число:  " + max);