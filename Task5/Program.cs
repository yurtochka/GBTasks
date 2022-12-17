using static System.Console;

Write("Введите число: ");
int x = int.Parse(ReadLine()!);
int count = -x;

while (x + 1 > count)
{
    WriteLine(count);
    count++;
}