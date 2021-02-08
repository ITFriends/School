catch
{
    // выполняемые инструкции
}

catch (тип_исключения)
{
    // выполняемые инструкции
}

try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Возникло исключение DivideByZeroException");
}

catch (тип_исключения имя_переменной)
{
    // выполняемые инструкции
}

try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Возникло исключение {ex.Message}");
}

catch when (условие)
{

}

int x = 1;
int y = 0;

try
{
    int result = x / y;
}
catch (DivideByZeroException) when (y == 0 && x == 0)
{
    Console.WriteLine("y не должен быть равен 0");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}