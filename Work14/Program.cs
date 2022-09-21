//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Метод проверки кратности числа
int IsMultiple(int number, int multiple)
{
  if (number % multiple == 0)
  {
    return 1;
  }
  else
  {
    return -1;
  }
}

// Метод проверки одновременной кратности 7 и 23
void BothMultiple7and23(int enterNumber)
{
  if (IsMultiple(enterNumber, 7) == 1 && IsMultiple(enterNumber, 23) == 1)
  {
    Console.WriteLine("Введенная цифра: " + enterNumber + " кратна одновременно и 7 и 23");    
  }
  else
  {
    Console.WriteLine("Введенная цифра: " + enterNumber + " не кратна одновременно и 7 и 23"); 
  }
}

//Ввод проверяемой цифры
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Вызов методов
BothMultiple7and23(number);