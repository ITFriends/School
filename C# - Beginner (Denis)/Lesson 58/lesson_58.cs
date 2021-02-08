﻿int[] numbers = new int[] { 97, 45, 32, 65, 83, 23, 15 };
Array.Sort(numbers);
foreach (int n in numbers)
    Console.WriteLine(n);

public interface IComparable
{
    int CompareTo(object o);
}

class Person : IComparable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(object o)
    {
        Person p = o as Person;
        if (p != null)
            return this.Name.CompareTo(p.Name);
        else
            throw new Exception("Невозможно сравнить два объекта");
    }
}

Person p1 = new Person { Name = "Bill", Age = 34 };
Person p2 = new Person { Name = "Tom", Age = 23 };
Person p3 = new Person { Name = "Alice", Age = 21 };

Person[] people = new Person[] { p1, p2, p3 };
Array.Sort(people);

foreach (Person p in people)
{
    Console.WriteLine($"{p.Name} - {p.Age}");
}

class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(Person p)
    {
        return this.Name.CompareTo(p.Name);
    }
}
Применение компаратора
Кроме интерфейса IComparable платформа .NET также предоставляет интерфейс IComparer:

1
2
3
4
interface IComparer
{
    int Compare(object o1, object o2);
}

class PeopleComparer : IComparer<Person>
{
    public int Compare(Person p1, Person p2)
    {
        if (p1.Name.Length > p2.Name.Length)
            return 1;
        else if (p1.Name.Length < p2.Name.Length)
            return -1;
        else
            return 0;
    }
}

Person p1 = new Person { Name = "Bill", Age = 34 };
Person p2 = new Person { Name = "Tom", Age = 23 };
Person p3 = new Person { Name = "Alice", Age = 21 };

Person[] people = new Person[] { p1, p2, p3 };
Array.Sort(people, new PeopleComparer());

foreach (Person p in people)
{
    Console.WriteLine($"{p.Name} - {p.Age}");
}
