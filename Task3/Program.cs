using static System.Console;

Write("Введите номер дня недели: ");
int x = int.Parse(ReadLine());

if (x == 1)
    WriteLine("День недели - понедельник.");
else
    if (x == 2)
        WriteLine("День недели - вторник.");
    else
        if (x == 3)
            WriteLine("День недели - среда.");
        else
            if (x == 4)
                WriteLine("День недели - четверг.");
            else
                if (x == 5)
                    WriteLine("День недели - пятница.");
                else
                    if (x == 6)
                        WriteLine("День недели - суббота.");
                    else
                        if (x == 7)
                            WriteLine("День недели - воскресенье.");
                        else
                            WriteLine("Число не входит в диапозон!");
