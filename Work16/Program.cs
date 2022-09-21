//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b || b == a*a) 
  Console.WriteLine("Одно число является квадратом другого");
else   Console.WriteLine("Ни одно из чисел не является квадратом другого"); 