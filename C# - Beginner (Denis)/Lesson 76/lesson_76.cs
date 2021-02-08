foreach (var item in перечислимый_объект)
{

}

public interface IEnumerable
{
    IEnumerator GetEnumerator();
}

public interface IEnumerator
{
    bool MoveNext(); // перемещение на одну позицию вперед в контейнере элементов
    object Current { get; }  // текущий элемент в контейнере
    void Reset(); // перемещение в начало контейнера
}

using System;
using System.Collections;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 2, 4, 6, 8, 10 };

            IEnumerator ie = numbers.GetEnumerator(); // получаем IEnumerator
            while (ie.MoveNext())   // пока не будет возвращено false
            {
                int item = (int)ie.Current;     // берем элемент на текущей позиции
                Console.WriteLine(item);
            }
            ie.Reset(); // сбрасываем указатель в начало массива
            Console.Read();
        }
    }
}

using System;
using System.Collections;
 
namespace HelloApp
{
    class Week : IEnumerable
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
            Console.Read();
        }
    }
}

public IEnumerator GetEnumerator()
{
    return days.GetEnumerator();
}

class Week
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                        "Friday", "Saturday", "Sunday" };

    public IEnumerator GetEnumerator()
    {
        return days.GetEnumerator();
    }
}

using System;
using System.Collections;
 
namespace HelloApp
{
    class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();
                return days[position];
            }
        }

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
    class Week
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
 
namespace HelloApp
{
    class Week
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday" };

        public IEnumerator<string> GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
    class WeekEnumerator : IEnumerator<string>
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }

        public string Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();
                return days[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
        public void Dispose() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
            Console.Read();
        }
    }
}