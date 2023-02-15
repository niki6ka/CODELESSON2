// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Please enter a three-digit number: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number / 100 < 1 || Number / 100 > 10)
{ Console.WriteLine("It's not a three digit number!!! Are you a stupid?"); }
else
{
    int a = Number % 100;
    int b = a / 10;
    Console.WriteLine("The second digit of this " + Number + " three-digit number is " + b);
}