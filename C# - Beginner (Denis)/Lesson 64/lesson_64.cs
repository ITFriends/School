static int Select(int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: throw new ArgumentException("Недопустимый код операции");
    }
}

try
{
    int x = Select(1, 4, 10);
    Console.WriteLine(x);

    x = Select(12, 4, 10);
    Console.WriteLine(x);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }

static int Select(int op, int a, int b)
{
    int result = op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => throw new ArgumentException("Недопустимый код операции")
    };
    return result;
}

static int Select(int op, int a, int b)
{
    return op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => throw new ArgumentException("Недопустимый код операции")
    };
}

static int Select(int op, int a, int b) => op switch
{
    1 => a + b,
    2 => a - b,
    3 => a * b,
    _ => throw new ArgumentException("Недопустимый код операции")
};

class Person
{
    public string Name { get; set; }        // имя пользователя
    public string Status { get; set; }      // статус пользователя
    public string Language { get; set; }    // язык пользователя
}

static string GetMessage(Person p) => p switch
{
    { Language: "english" } => "Hello!",
    { Language: "german", Status: "admin" } => "Hallo, admin!",
    { Language: "french" } => "Salut!",
    { } => "undefined"
};

static void Main(string[] args)
{
    Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
    string message = GetMessage(pierre);
    Console.WriteLine(message);     // Salut!

    Person tomas = new Person { Language = "german", Status = "admin", Name = "Tomas" };
    Console.WriteLine(GetMessage(tomas));     // Hallo, admin!

    Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo" };
    Console.WriteLine(GetMessage(pablo));     // undefined
}

static string GetMessage(Person p) => p switch
{
    { Language: "english" } => "Hello!",
    { Language: "german", Status: "admin" } => "Hallo!",
    { Language: "french" } => "Salut!",
    { } => "undefined",
    null => "null"       // если Person p = null
};

static string GetMessage(Person p) => p switch
{
    { Language: "german", Status: "admin" } => "Hallo, admin!",
    { Language: "french", Name: var name } => $"Salut, {name}!",
    { Language: var lang } => $"Unknown language: {lang}",
    null => "null"
};

static void Main(string[] args)
{
    Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
    string message = GetMessage(pierre);
    Console.WriteLine(message);             // Salut, Pierre!

    Person tomas = new Person { Language = "german", Status = "admin", Name = "Tomas" };
    Console.WriteLine(GetMessage(tomas));     // Hallo, admin!

    Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo" };
    Console.WriteLine(GetMessage(pablo));     // Unknown language: spanish

    Person bob = null;
    Console.WriteLine(GetMessage(bob));         // null
}

static string GetWelcome(string lang, string daytime) => (lang, daytime) switch
{
    ("english", "morning") => "Good morning",
    ("english", "evening") => "Good evening",
    ("german", "morning") => "Guten Morgen",
    ("german", "evening") => "Guten Abend",
    _ => "Здрасьть"
};

static void Main(string[] args)
{
    string message = GetWelcome("english", "evening");
    Console.WriteLine(message);  // Good evening

    message = GetWelcome("french", "morning");
    Console.WriteLine(message);  // Здрасьть
}

static string GetWelcome(string lang, string daytime, string status) => (lang, daytime, status) switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    _ => "Здрасьть"
};

static void Main(string[] args)
{
    string message = GetWelcome("english", "evening", "user");
    Console.WriteLine(message);  // Good evening

    message = GetWelcome("french", "morning", "admin");
    Console.WriteLine(message);  // Hello, Admin
}

class MessageDetails
{
    public string Language { get; set; }    // язык пользователя
    public string DateTime { get; set; }    // время суток
    public string Status { get; set; }      // статус пользователя

    public void Deconstruct(out string lang, out string datetime, out string status)
    {
        lang = Language;
        datetime = DateTime;
        status = Status;
    }
}

static string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    _ => "Здрасьть"
};

static void Main(string[] args)
{
    MessageDetails details1 = new MessageDetails { Language = "english", DateTime = "evening", Status = "user" };
    string message = GetWelcome(details1);
    Console.WriteLine(message);  // Good evening

    MessageDetails details2 = new MessageDetails { Language = "french", DateTime = "morning", Status = "admin" };
    message = GetWelcome(details2);
    Console.WriteLine(message);  // Hello, Admin
}

static string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    (var lang, var datetime, var status) => $"{lang} not found, {datetime} unknown, {status} undefined",
    _ => "Здрасьть"
};

static decimal Calculate(decimal sum)
{
    return sum switch
    {
        <= 0 => 0,              // если sum меньше или равно 0, возвращаем 0
        < 50000 => sum * 0.05m, // если sum меньше 50000, возвращаем sum * 0.05m
        < 100000 => sum * 0.1m, // если sum меньше 100000, возвращаем sum * 0.1m
        _ => sum * 0.2m        // в остальных случаях возвращаем sum * 0.2m
    };
}

Console.WriteLine(Calculate(-200));     // 0
Console.WriteLine(Calculate(0));        // 0 
Console.WriteLine(Calculate(10000));    // 500
Console.WriteLine(Calculate(60000));    // 6000
Console.WriteLine(Calculate(200000));   // 40000

static string CheckAge(int age)
{
    return age switch
    {
        < 1 or > 110 => "Недействительный возраст",   // если age больше 110 и меньше 1
        >= 1 and < 18 => "Доступ запрещен",           // если age равно или больше 1 и меньше 18
        _ => "Доступ разрешен"                      // в остальных случаях
    };
}

Console.WriteLine(CheckAge(200));     // Недействительный возраст
Console.WriteLine(CheckAge(0));      // Недействительный возраст 
Console.WriteLine(CheckAge(17));    // Доступ запрещен
Console.WriteLine(CheckAge(18));   // Доступ разрешен

static string CheckAge(int age) => age switch
{
    not 33 => "Обычный возраст",   // если age НЕ равен 33
    _ => "Вам 33 года"             // в остальных случаях, то есть если age = 33
};