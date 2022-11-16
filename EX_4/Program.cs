/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Введите первое числа");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе числа");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье числа");
int numberThird = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
    Console.WriteLine($"наибольшее число {numberFirst}");
}
if (numberSecond > numberThird)
{
    Console.WriteLine($"наибольшее число {numberSecond}");
}
if (numberThird > numberFirst)
{
    Console.WriteLine($"наибольшее число {numberThird}");
}