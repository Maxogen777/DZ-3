Console.Clear();
Console.WriteLine("Задача 19: \n  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. \n" );

Console.WriteLine("Введите 5-значное число: ");
int num = int.Parse(Console.ReadLine());

while (num / 10000 == 0 | num / 100000 != 0 )    // проверка числа на 5-значность
    { 
        Console.WriteLine("Вы ввели некорректное число, повторите попытку!");
        Console.WriteLine("Введите 5-значное число: ");
        num = int.Parse(Console.ReadLine());    
    }

if ((num / 10000 == num % 10) && (num /1000 % 10 == (num % 100)/10))
    {
        Console.WriteLine($"число {num} - полином!");
    }
else 
    {
        Console.WriteLine($"число {num} - не полином!");
    }


System.Console.WriteLine("\n\nЗадача 21: \n  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. \n" );

Console.WriteLine("Введите координаты 1-й точки: ");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты 2-й точки: ");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine());

double s = Math.Round(Math.Sqrt((Math.Pow(x2-x1,2))+(Math.Pow(y2-y1,2))+(Math.Pow(z2-z1,2))),2);
Console.WriteLine($"Расстояние между этими точками = {s}");


Console.WriteLine("\n\nЗадача 23: \n  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. \n" );

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
for (int i=1; i<=num; i++)
    {
        Console.Write($"{Math.Pow(i,3)}  ");
    }
