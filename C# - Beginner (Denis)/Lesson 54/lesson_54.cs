IMovable m = new IMovable(); // ! Ошибка, так сделать нельзя

interface IMovable
{
    void Move();
}

// применение интерфейса в классе
class Person : IMovable
{
    public void Move()
    {
        Console.WriteLine("Человек идет");
    }
}
// применение интерфейса в структуре
struct Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Машина едет");
    }
}

using System;
 
namespace HelloApp
{
    interface IMovable
    {
        void Move();
    }
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Человек идет");
        }
    }
    struct Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
    class Program
    {
        static void Action(IMovable movable)
        {
            movable.Move();
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            Car car = new Car();
            Action(person);
            Action(car);
            Console.Read();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable tom = new Person();
        Car tesla = new Car();
        tom.Move();     // Walking
        tesla.Move();   // Driving
    }
}

interface IMovable
{
    void Move()
    {
        Console.WriteLine("Walking");
    }
}
class Person : IMovable { }
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Driving");
    }
}

Person tom = new Person();
tom.Move();     // Ошибка - метод Move не определен в классе Person

using System;
 
namespace HelloApp
{
    interface IAccount
    {
        int CurrentSum { get; }  // Текущая сумма на счету
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
        public string Name { get; set; }
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }

        public int CurrentSum { get { return _sum; } }

        public void Put(int sum) { _sum += sum; }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Tom", 200);
            client.Put(30);
            Console.WriteLine(client.CurrentSum); //230
            client.Withdraw(100);
            Console.WriteLine(client.CurrentSum); //130
            Console.Read();
        }
    }
}

// Все объекты Client являются объектами IAccount 
IAccount account = new Client("Том", 200);
account.Put(200);
Console.WriteLine(account.CurrentSum); // 400
// Не все объекты IAccount являются объектами Client, необходимо явное приведение
Client client = (Client)account;
// Интерфейс IAccount не имеет свойства Name, необходимо явное приведение
string clientName = ((Client)account).Name;