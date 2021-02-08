Dictionary<int, string> countries = new Dictionary<int, string>(5);
countries.Add(1, "Russia");
countries.Add(3, "Great Britain");
countries.Add(2, "USA");
countries.Add(4, "France");
countries.Add(5, "China");

foreach (KeyValuePair<int, string> keyValue in countries)
{
    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
}

// получение элемента по ключу
string country = countries[4];
// изменение объекта
countries[4] = "Spain";
// удаление по ключу
countries.Remove(2);

Dictionary<char, Person> people = new Dictionary<char, Person>();
people.Add('b', new Person() { Name = "Bill" });
people.Add('t', new Person() { Name = "Tom" });
people.Add('j', new Person() { Name = "John" });

foreach (KeyValuePair<char, Person> keyValue in people)
{
    // keyValue.Value представляет класс Person
    Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
}

// перебор ключей
foreach (char c in people.Keys)
{
    Console.WriteLine(c);
}

// перебор по значениям
foreach (Person p in people.Values)
{
    Console.WriteLine(p.Name);
}

Dictionary<char, Person> people = new Dictionary<char, Person>();
people.Add('b', new Person() { Name = "Bill" });
people['a'] = new Person() { Name = "Alice" };

Dictionary<string, string> countries = new Dictionary<string, string>
{
    {"Франция", "Париж"},
    {"Германия", "Берлин"},
    {"Великобритания", "Лондон"}
};

foreach (var pair in countries)
    Console.WriteLine("{0} - {1}", pair.Key, pair.Value);


Dictionary<string, string> countries = new Dictionary<string, string>
{
    ["Франция"] = "Париж",
    ["Германия"] = "Берлин",
    ["Великобритания"] = "Лондон"
};