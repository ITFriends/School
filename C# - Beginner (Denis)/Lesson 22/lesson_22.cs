struct User
{
    public string name;
    public int age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}  Age: {age}");
    }
}

using System;
 
namespace HelloApp
{
    struct User
    {
        public string name;
        public int age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User tom;
            tom.name = "Tom";
            tom.age = 34;
            tom.DisplayInfo();

            Console.ReadKey();
        }
    }
}

User tom;
int x = tom.age;    // Ошибка
tom.DisplayInfo();  // Ошибка

User tom = new User();
tom.DisplayInfo();  // Name:   Age: 0

using System;
 
namespace HelloApp
{
    struct User
    {
        public string name;
        public int age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom", 34);
            tom.DisplayInfo();

            User bob = new User();
            bob.DisplayInfo();

            Console.ReadKey();
        }
    }
}

struct User
{
    public string name = "Sam";     // ! Ошибка
    public int age = 23;            // ! Ошибка
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}  Age: {age}");
    }
}