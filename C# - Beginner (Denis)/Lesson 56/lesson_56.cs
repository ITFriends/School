interface IAccount
{
    int CurrentSum { get; } // Текущая сумма на счету
    void Put(int sum);      // Положить деньги на счет
    void Withdraw(int sum); // Взять со счета
}
interface IClient
{
    string Name { get; set; }
}
class Client : IAccount, IClient
{
    int _sum; // Переменная для хранения суммы
    public Client(string name, int sum)
    {
        Name = name;
        _sum = sum;
    }

    public string Name { get; set; }
    public int CurrentSum
    {
        get { return _sum; }
    }
    public void Put(int sum)
    {
        _sum += sum;
    }
    public void Withdraw(int sum)
    {
        if (sum <= _sum)
        {
            _sum -= sum;
        }
    }
}

class Transaction<T> where T : IAccount, IClient
{
    public void Operate(T acc1, T acc2, int sum)
    {
        if (acc1.CurrentSum >= sum)
        {
            acc1.Withdraw(sum);
            acc2.Put(sum);
            Console.WriteLine($"{acc1.Name} : {acc1.CurrentSum}\n{acc2.Name} : {acc2.CurrentSum}");
        }
    }
}

Client account1 = new Client("Tom", 200);
Client account2 = new Client("Bob", 300);
Transaction<Client> transaction = new Transaction<Client>();
transaction.Operate(account1, account2, 150);

interface IClientAccount : IAccount, IClient
{

}
class ClientAccount : IClientAccount
{
    int _sum;
    public ClientAccount(string name, int sum)
    {
        _sum = sum; Name = name;
    }
    public int CurrentSum { get { return _sum; } }

    public string Name { get; set; }

    public void Put(int sum)
    {
        _sum += sum;
    }
    public void Withdraw(int sum)
    {
        if (_sum >= sum) _sum -= sum;
    }
}

IClientAccount account3 = new ClientAccount("Alice", 400);
IClientAccount account4 = new ClientAccount("Kate", 500);
Transaction<IClientAccount> operation = new Transaction<IClientAccount>();
operation.Operate(account3, account4, 200);

interface IUser<T>
{
    T Id { get; }
}
class User<T> : IUser<T>
{
    T _id;
    public User(T id)
    {
        _id = id;
    }
    public T Id { get { return _id; } }
}

IUser<int> user1 = new User<int>(6789);
Console.WriteLine(user1.Id);    // 6789

IUser<string> user2 = new User<string>("12345");
Console.WriteLine(user2.Id);    // 12345

class IntUser : IUser<int>
{
    int _id;
    public IntUser(int id)
    {
        _id = id;
    }
    public int Id { get { return _id; } }
}