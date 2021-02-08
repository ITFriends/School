
int num1 = 8;
int num2 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}

int num1 = 8;
int num2 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}


int num1 = 8;
int num2 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine("Число num1 равно числу num2");
}

int num1 = 8;
int num2 = 6;
if (num1 > num2 && num1 == 8)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}


Console.WriteLine("Нажмите Y или N");
string selection = Console.ReadLine();
switch (selection)
{
    case "Y":
        Console.WriteLine("Вы нажали букву Y");
        break;
    case "N":
        Console.WriteLine("Вы нажали букву N");
        break;
    default:
        Console.WriteLine("Вы нажали неизвестную букву");
        break;
}

int number = 1;
switch (number)
{
    case 1:
        Console.WriteLine("case 1");
        goto case 5; // переход к case 5
    case 3:
        Console.WriteLine("case 3");
        break;
    case 5:
        Console.WriteLine("case 5");
        break;
    default:
        Console.WriteLine("default");
        break;
}

int x = 3;
int y = 2;
Console.WriteLine("Нажмите + или -");
string selection = Console.ReadLine();

int z = selection == "+" ? (x + y) : (x - y);
Console.WriteLine(z);
