using static System.Console;

Write("Введите трехзначное число: ");
int x = int.Parse(ReadLine()!);

if (x > 99 & x < 1000)
{
    x = x % 10;
    WriteLine($"Третий символ числа {x}");
}
else 
    WriteLine("Число не трехзначное!");