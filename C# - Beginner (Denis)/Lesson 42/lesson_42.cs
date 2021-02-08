class Account
{
    public int Id { get; private set; } // номер счета
    public int Sum { get; set; }
    public Account(int _id)
    {
        Id = _id;
    }
}

class Transaction<T> where T : Account
{
    public T FromAccount { get; set; }  // с какого счета перевод
    public T ToAccount { get; set; }    // на какой счет перевод
    public int Sum { get; set; }        // сумма перевода

    public void Execute()
    {
        if (FromAccount.Sum > Sum)
        {
            FromAccount.Sum -= Sum;
            ToAccount.Sum += Sum;
            Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
        }
        else
        {
            Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account acc1 = new Account(1857) { Sum = 4500 };
        Account acc2 = new Account(3453) { Sum = 5000 };
        Transaction<Account> transaction1 = new Transaction<Account>
        {
            FromAccount = acc1,
            ToAccount = acc2,
            Sum = 6900
        };
        transaction1.Execute();

        Console.ReadLine();
    }
}

class Program
{
    private static void Main(string[] args)
    {
        Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
        Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

        Transaction<Account<int>> transaction1 = new Transaction<Account<int>>
        {
            FromAccount = acc1,
            ToAccount = acc2,
            Sum = 6900
        };
        transaction1.Execute();

        Console.Read();
    }
}
class Account<T>
{
    public T Id { get; private set; } // номер счета
    public int Sum { get; set; }
    public Account(T _id)
    {
        Id = _id;
    }
}
class Transaction<T> where T : Account<int>
{
    public T FromAccount { get; set; }  // с какого счета перевод
    public T ToAccount { get; set; }    // на какой счет перевод
    public int Sum { get; set; }        // сумма перевода

    public void Execute()
    {
        if (FromAccount.Sum > Sum)
        {
            FromAccount.Sum -= Sum;
            ToAccount.Sum += Sum;
            Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
        }
        else
        {
            Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
        }
    }
}

Account<string> acc1 = new Account<string>("34") { Sum = 4500 };
Account<string> acc2 = new Account<string>("45") { Sum = 5000 };

// так нельзя написать, так как Bank должен быть типизирован классом Account<int> или его наследником
Transaction<Account<string>> transaction1 = new Transaction<Account<string>>
{
    FromAccount = acc1,
    ToAccount = acc2,
    Sum = 900
};

class Account<T> where T : struct
{ }

class Transaction<T> where T : class
{ }
А также можно задать с помощью слова new в качестве ограничения класс или структуру, которые имеют общедоступный конструктор без параметров:

class Transaction<T> where T : new()
{ }

interface IAccount
{
    int CurrentSum { get; set; }
}
class Person
{
    public string Name { get; set; }
}

class Transaction<T> where T : Person, IAccount, new()
{

}

class Transaction<U, V>
        where U : Account<int>
        where V : struct
{

}

private static void Main(string[] args)
{
    Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
    Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

    Transact<Account<int>>(acc1, acc2, 900);

    Console.Read();
}

public static void Transact<T>(T acc1, T acc2, int sum) where T : Account<int>
{
    if (acc1.Sum > sum)
    {
        acc1.Sum -= sum;
        acc2.Sum += sum;
    }
    Console.WriteLine($"acc1: {acc1.Sum}   acc2: {acc2.Sum}");
}