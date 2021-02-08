class Person
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
}

Person p = new Person();

// Устанавливаем свойство - срабатывает блок Set
// значение "Tom" и есть передаваемое в свойство value
p.Name = "Tom";

// Получаем значение свойства и присваиваем его переменной - срабатывает блок Get
string personName = p.Name;
Возможно, может возникнуть вопрос, зачем нужны свойства, если мы можем в данной ситуации обходиться обычными полями класса? Но свойства позволяют вложить дополнительную логику, которая может быть необходима, например, при присвоении переменной класса какого-либо значения. Например, нам надо установить проверку по возрасту:

class Person
{
    private int age;

    public int Age
    {
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть больше 17");
            }
            else
            {
                age = value;
            }
        }
        get { return age; }
    }
}

class Person
{
    private string name;
    // свойство только для чтения
    public string Name
    {
        get
        {
            return name;
        }
    }

    private int age;
    // свойство только для записи
    public int Age
    {
        set
        {
            age = value;
        }
    }
}

class Person
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }

        private set
        {
            name = value;
        }
    }
    public Person(string name)
    {
        Name = name;
    }
}

Person p = new Person("Tom");

// Ошибка - set объявлен с модификатором private
//p.Name = "John";

Console.WriteLine(p.Name);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Person
{
    public string Name { get; set; } = "Tom";
    public int Age { get; set; } = 23;
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Console.WriteLine(person.Name); // Tom
        Console.WriteLine(person.Age);  // 23

        Console.Read();
    }
}

class Person
{
    public string Name { private set; get; }
    public Person(string n)
    {
        Name = n;
    }
}

class Person
{
    public string Name { get; } = "Tom"
}

class Person
{
    private string name;

    // эквивалентно public string Name { get { return name; } }
    public string Name => name;
}