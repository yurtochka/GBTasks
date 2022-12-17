using static System.Console;

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int b = int.Parse(ReadLine());

if (a == b * b) 
    WriteLine($"Число {a} является квадратом {b}");
else 
    WriteLine($"Число {a} не является квадратом {b}");
    