/* Задача 8: Напишите программу, которая на вход принимает число (N > 0),
 а на выходе показывает все чётные числа от 1 до N. */

Console.WriteLine("Введите число больше 0");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

if(number > 1)
{
    while(count <= number)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
Console.WriteLine();


