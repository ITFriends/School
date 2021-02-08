class Account
{
    public Account(int sum)
    {
        Sum = sum;
    }
    // сумма на счете
    public int Sum { get; private set; }
    // добавление средств на счет
    public void Put(int sum)
    {
        Sum += sum;
    }
    // списание средств со счета
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
        }
    }
}

static void Main(string[] args)
{
    Account acc = new Account(100);
    acc.Put(20);    // добавляем на счет 20
    Console.WriteLine($"Сумма на счете: {acc.Sum}");
    acc.Take(70);   // пытаемся снять со счета 70
    Console.WriteLine($"Сумма на счете: {acc.Sum}");
    acc.Take(180);  // пытаемся снять со счета 180
    Console.WriteLine($"Сумма на счете: {acc.Sum}");
    Console.Read();
}

public void Put(int sum)
{
    Sum += sum;
    Console.WriteLine($"На счет поступило: {sum}");
}

class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler Notify;              // 1.Определение события
    public Account(int sum)
    {
        Sum = sum;
    }
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
        }
        else
        {
            Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(100);
        acc.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
        acc.Put(20);    // добавляем на счет 20
        Console.WriteLine($"Сумма на счете: {acc.Sum}");
        acc.Take(70);   // пытаемся снять со счета 70
        Console.WriteLine($"Сумма на счете: {acc.Sum}");
        acc.Take(180);  // пытаемся снять со счета 180
        Console.WriteLine($"Сумма на счете: {acc.Sum}");
        Console.Read();
    }
    private static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(100);
        acc.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage
        acc.Notify += DisplayRedMessage;    // добавляем обработчик DisplayMessage
        acc.Put(20);    // добавляем на счет 20
        acc.Notify -= DisplayRedMessage;     // удаляем обработчик DisplayRedMessage
        acc.Put(20);    // добавляем на счет 20
        Console.Read();
    }

    private static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    private static void DisplayRedMessage(String message)
    {
        // Устанавливаем красный цвет символов
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        // Сбрасываем настройки цвета
        Console.ResetColor();
    }
}

static void Main(string[] args)
{
    Account acc = new Account(100);
    // установка делегата, который указывает на метод DisplayMessage
    acc.Notify += new ActionHandler(DisplayMessage);
    // установка в качестве обработчика метода DisplayMessage
    acc.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage

    acc.Put(20);    // добавляем на счет 20
    Console.Read();
}

private static void DisplayMessage(string message)
{
    Console.WriteLine(message);
}

static void Main(string[] args)
{
    Account acc = new Account(100);
    acc.Notify += delegate (string mes)
    {
        Console.WriteLine(mes);
    };

    acc.Put(20);
    Console.Read();
}

static void Main(string[] args)
{
    Account acc = new Account(100);
    acc.Notify += mes => Console.WriteLine(mes);

    acc.Put(20);
    Console.Read();
}

class Account
{
    public delegate void AccountHandler(string message);
    private event AccountHandler _notify;
    public event AccountHandler Notify
    {
        add
        {
            _notify += value;
            Console.WriteLine($"{value.Method.Name} добавлен");
        }
        remove
        {
            _notify -= value;
            Console.WriteLine($"{value.Method.Name} удален");
        }
    }
    public Account(int sum)
    {
        Sum = sum;
    }
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        _notify?.Invoke($"На счет поступило: {sum}");
    }

    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            _notify?.Invoke($"Со счета снято: {sum}");
        }
        else
        {
            _notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
        }
    }
}

private event AccountHandler _notify;


class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(100);
        acc.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage
        acc.Put(20);    // добавляем на счет 20
        acc.Notify -= DisplayMessage;     // удаляем обработчик DisplayRedMessage
        acc.Put(20);    // добавляем на счет 20

        Console.Read();
    }
    private static void DisplayMessage(string message) => Console.WriteLine(message);
}

class AccountEventArgs
{
    // Сообщение
    public string Message { get; }
    // Сумма, на которую изменился счет
    public int Sum { get; }

    public AccountEventArgs(string mes, int sum)
    {
        Message = mes;
        Sum = sum;
    }
}

class Account
{
    public delegate void AccountHandler(object sender, AccountEventArgs e);
    public event AccountHandler Notify;
    public Account(int sum)
    {
        Sum = sum;
    }
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
        }
        else
        {
            Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum)); ;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(100);
        acc.Notify += DisplayMessage;
        acc.Put(20);
        acc.Take(70);
        acc.Take(150);
        Console.Read();
    }
    private static void DisplayMessage(object sender, AccountEventArgs e)
    {
        Console.WriteLine($"Сумма транзакции: {e.Sum}");
        Console.WriteLine(e.Message);
    }
}