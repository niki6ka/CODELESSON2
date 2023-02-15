// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Please enter any number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Original = Number;
if (Number / 100 < 1 )
{ Console.WriteLine("There is no third digit in this number"); }
else
        {
        while (Number > 999)
            {
            Number = Number / 10;
            }
        int a = Number % 10;
        Console.WriteLine("The third digit of this " + Original + " number is " + a);
        }