class Account
{
    public static decimal bonus = 100;
    public decimal totalSum;
    public Account(decimal sum)
    {
        totalSum = sum + bonus;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Account.bonus);      // 100
        Account.bonus += 200;

        Account account1 = new Account(150);
        Console.WriteLine(account1.totalSum);   // 450


        Account account2 = new Account(1000);
        Console.WriteLine(account2.totalSum);   // 1300

        Console.ReadKey();
    }
}

class Account
{
    public Account(decimal sum, decimal rate)
    {
        if (sum < MinSum) throw new Exception("Недопустимая сумма!");
        Sum = sum; Rate = rate;
    }
    private static decimal minSum = 100; // минимальная допустимая сумма для всех счетов
    public static decimal MinSum
    {
        get { return minSum; }
        set { if (value > 0) minSum = value; }
    }

    public decimal Sum { get; private set; }    // сумма на счете
    public decimal Rate { get; private set; }   // процентная ставка

    // подсчет суммы на счете через определенный период по определенной ставке
    public static decimal GetSum(decimal sum, decimal rate, int period)
    {
        decimal result = sum;
        for (int i = 1; i <= period; i++)
            result = result + result * rate / 100;
        return result;
    }
}

class User
{
    private static int counter = 0;
    public User()
    {
        counter++;
    }

    public static void DisplayCounter()
    {
        Console.WriteLine($"Создано {counter} объектов User");
    }
}
class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        User user2 = new User();
        User user3 = new User();
        User user4 = new User();
        User user5 = new User();

        User.DisplayCounter(); // 5

        Console.ReadKey();
    }
}

class User
{
    static User()
    {
        Console.WriteLine("Создан первый пользователь");
    }
}
class Program
{
    static void Main(string[] args)
    {
        User user1 = new User(); // здесь сработает статический конструктор
        User user2 = new User();

        Console.Read();
    }
}

static class Account
{
    private static decimal minSum = 100; // минимальная допустимая сумма для всех счетов
    public static decimal MinSum
    {
        get { return minSum; }
        set { if (value > 0) minSum = value; }
    }

    // подсчет суммы на счете через определенный период по определенной ставке
    public static decimal GetSum(decimal sum, decimal rate, int period)
    {
        decimal result = sum;
        for (int i = 1; i <= period; i++)
            result = result + result * rate / 100;
        return result;
    }
}