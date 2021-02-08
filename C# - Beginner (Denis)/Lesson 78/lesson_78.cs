string s1 = "hello";
string s2 = "world";
string s3 = s1 + " " + s2; // результат: строка "hello world"
string s4 = String.Concat(s3, "!!!"); // результат: строка "hello world!!!"

Console.WriteLine(s4);

string s5 = "apple";
string s6 = "a day";
string s7 = "keeps";
string s8 = "a doctor";
string s9 = "away";
string[] values = new string[] { s5, s6, s7, s8, s9 };

String s10 = String.Join(" ", values);
// результат: строка "apple a day keeps a doctor away"

string s1 = "hello";
string s2 = "world";

int result = String.Compare(s1, s2);
if (result < 0)
{
    Console.WriteLine("Строка s1 перед строкой s2");
}
else if (result > 0)
{
    Console.WriteLine("Строка s1 стоит после строки s2");
}
else
{
    Console.WriteLine("Строки s1 и s2 идентичны");
}
// результатом будет "Строка s1 перед строкой s2"

string s1 = "hello world";
char ch = 'o';
int indexOfChar = s1.IndexOf(ch); // равно 4
Console.WriteLine(indexOfChar);

string subString = "wor";
int indexOfSubstring = s1.IndexOf(subString); // равно 6
Console.WriteLine(indexOfSubstring);

string path = @"C:\SomeDir";

string[] files = Directory.GetFiles(path);

for (int i = 0; i < files.Length; i++)
{
    if (files[i].EndsWith(".exe"))
        File.Delete(files[i]);
}

string text = "И поэтому все так произошло";

string[] words = text.Split(new char[] { ' ' });

foreach (string s in words)
{
    Console.WriteLine(s);
}

string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

string text = " hello world ";

text = text.Trim(); // результат "hello world"
text = text.Trim(new char[] { 'd', 'h' }); // результат "ello worl"

string text = "Хороший день";
// обрезаем начиная с третьего символа
text = text.Substring(2);
// результат "роший день"
Console.WriteLine(text);
// обрезаем сначала до последних двух символов
text = text.Substring(0, text.Length - 2);
// результат "роший де"
Console.WriteLine(text);

string text = "Хороший день";
string subString = "замечательный ";

text = text.Insert(8, subString);
Console.WriteLine(text);

string text = "Хороший день";
// индекс последнего символа
int ind = text.Length - 1;
// вырезаем последний символ
text = text.Remove(ind);
Console.WriteLine(text);

// вырезаем первые два символа
text = text.Remove(0, 2);

string text = "хороший день";

text = text.Replace("хороший", "плохой");
Console.WriteLine(text);

text = text.Replace("о", "");
Console.WriteLine(text);

string hello = "Hello world!";

Console.WriteLine(hello.ToLower()); // hello world!
Console.WriteLine(hello.ToUpper()); // HELLO WORLD!

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person { Name = "Tom", Age = 23 };

        Console.WriteLine("Имя: {0}  Возраст: {1}", person.Name, person.Age);
        Console.Read();
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
В строке "Имя: {0} Возраст: {1}" на место {0} и
{ 1}

string output = String.Format("Имя: {0}  Возраст: {1}", person.Name, person.Age);
Console.WriteLine(output);


double number = 23.7;
string result = String.Format("{0:C}", number);
Console.WriteLine(result); // $ 23.7
string result2 = String.Format("{0:C2}", number);
Console.WriteLine(result2); // $ 23.70

int number = 23;
string result = String.Format("{0:d}", number);
Console.WriteLine(result); // 23
string result2 = String.Format("{0:d4}", number);
Console.WriteLine(result2); // 0023

int number = 23;
string result = String.Format("{0:f}", number);
Console.WriteLine(result); // 23,00

double number2 = 45.08;
string result2 = String.Format("{0:f4}", number2);
Console.WriteLine(result2); // 45,0800

double number3 = 25.07;
string result3 = String.Format("{0:f1}", number3);
Console.WriteLine(result2); // 25,1

decimal number = 0.15345m;
Console.WriteLine("{0:P1}", number);// 15.3%

long number = 19876543210;
string result = String.Format("{0:+# (###) ###-##-##}", number);
Console.WriteLine(result); // +1 (987) 654-32-10

long number = 19876543210;
Console.WriteLine(number.ToString("+# (###) ###-##-##"));// +1 (987) 654-32-10

double money = 24.8;
Console.WriteLine(money.ToString("C2")); // $ 24,80

Person person = new Person { Name = "Tom", Age = 23 };

Console.WriteLine($"Имя: {person.Name}  Возраст: {person.Age}");

int x = 8;
int y = 7;
string result = $"{x} + {y} = {x + y}";
Console.WriteLine(result); // 8 + 7 = 15

person = null;
string output = $"{person?.Name ?? "Имя по умолчанию"}";
Console.WriteLine(output);

long number = 19876543210;
Console.WriteLine($"{number:+# ### ### ## ##}"); // +1 987 654 32 10

Console.WriteLine($"Имя: {person.Name,-5} Возраст: {person.Age}"); // пробелы после
Console.WriteLine($"Имя: {person.Name,5} Возраст: {person.Age}"); // пробелы до

StringBuilder sb = new StringBuilder("Привет мир");
Console.WriteLine($"Длина строки: {sb.Length}");
Console.WriteLine($"Емкость строки: {sb.Capacity}", );

StringBuilder sb = new StringBuilder(20);

StringBuilder sb = new StringBuilder("Название: ");
Console.WriteLine($"Длина строки: {sb.Length}"); // 10
Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 16

sb.Append(" Руководство");
Console.WriteLine($"Длина строки: {sb.Length}"); // 22
Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32

sb.Append(" по C#");
Console.WriteLine($"Длина строки: {sb.Length}"); // 28
Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32

StringBuilder sb = new StringBuilder("Привет мир");
sb.Append("!");
sb.Insert(7, "компьютерный ");
Console.WriteLine(sb);

// заменяем слово
sb.Replace("мир", "world");
Console.WriteLine(sb);

// удаляем 13 символов, начиная с 7-го
sb.Remove(7, 13);
Console.WriteLine(sb);

// получаем строку из объекта StringBuilder
string s = sb.ToString();
Console.WriteLine(s);