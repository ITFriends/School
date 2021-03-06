﻿class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Deconstruct(out string name, out int age)
    {
        name = this.Name;
        age = this.Age;
    }
}

Person person = new Person { Name = "Tom", Age = 33 };

(string name, int age) = person;

Console.WriteLine(name);    // Tom
Console.WriteLine(age);     // 33

Person person = new Person { Name = "Tom", Age = 33 };

string name; int age;
person.Deconstruct(out name, out age);

public void Deconstruct(out string name)
{
    name = this.Name;
}
