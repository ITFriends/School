using System;
using System.Collections;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }

    class Numbers
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 6; i++)
            {
                yield return i * i;
            }
        }
    }
}

class Book
{
    public Book(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }
}

class Library
{
    private Book[] books;

    public Library()
    {
        books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"),
                new Book("Евгений Онегин") };
    }

    public int Length
    {
        get { return books.Length; }
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < books.Length; i++)
        {
            yield return books[i];
        }
    }
}

foreach (Book b in library)
{
    Console.WriteLine(b.Name);
}

IEnumerator IEnumerable.GetEnumerator()
{
    yield return books[0];
    yield return books[1];
    yield return books[2];
}

class Book
{
    public Book(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }
}

class Library
{
    private Book[] books;

    public Library()
    {
        books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"),
            new Book("Евгений Онегин") };
    }

    public int Length
    {
        get { return books.Length; }
    }

    public IEnumerable GetBooks(int max)
    {
        for (int i = 0; i < max; i++)
        {
            if (i == books.Length)
            {
                yield break;
            }
            else
            {
                yield return books[i];
            }
        }
    }
}

Library library = new Library();

foreach (Book b in library.GetBooks(5))
{
    Console.WriteLine(b.Name);
}