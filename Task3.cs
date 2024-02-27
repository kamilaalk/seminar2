// Задача 3: Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

int a = 199;
int first = a / 10;
int second = a % 10;

if (a < 10 || a > 99)
{
    Console.WriteLine("Ошибка: Значение \"а\" должно быть в пределах [10, 99]");
}

else if (first > second)
{
    Console.WriteLine(first);
}

if (first < second)
{
    Console.WriteLine(second);
}

