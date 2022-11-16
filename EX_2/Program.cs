/* Задача 2: Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее. */

Console.WriteLine("Введите первое числа");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе числа");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if(numberFirst > numberSecond)
{
    Console.WriteLine($"набольшее число {numberFirst}, наименьшее число {numberSecond}");
}
else if (numberSecond > numberFirst)
{
     Console.WriteLine($"набольшее число {numberSecond}, наименьшее число {numberFirst}");
}

