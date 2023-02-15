// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter the number of the week day ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 1 || Number > 7)
{ Console.WriteLine("There are no such days of the week on Earth! Are you from Mars?"); }
else
    {
       switch (Number)
       {
        case 1:
        Console.WriteLine("OMG!!! The " + Number + " day of the week - Fucking Monday is not a holiday");
        break;
         case 2:
        Console.WriteLine("OMG!!! The " + Number + " day of the week - Fucking Tuesday is not a holiday");
        break;
         case 3:
        Console.WriteLine("OMG!!! The " + Number + " day of the week - Fucking Wednesday is not a holiday");
        break;
         case 4:
        Console.WriteLine("OMG!!! The " + Number + " day of the week - Fucking Thursday is not a holiday");
        break;
         case 5:
        Console.WriteLine("OMG!!! The " + Number + " day of the week - GOD Friday is not a holiday, but waiting for the evening :)))");
        break;
         case 6:
        Console.WriteLine("Hallelujah!!! The " + Number + " day of the week - Saturday is a holiday!!!");
        break;
         case 7:
        Console.WriteLine("Hallelujah!!! The " + Number + " day of the week - Sunday is a holiday");
        break;
        }
    }

Console.WriteLine("Have a nice day regardless of the day of the week!!!");