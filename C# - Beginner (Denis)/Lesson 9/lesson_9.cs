﻿//При рассмотрении типов данных указывалось, какие значения может иметь тот или иной 
//    тип и сколько байт памяти он может занимать. В прошлой теме были расмотрены
//    арифметические операции. Теперь применим операцию сложения к данным разных типов:

byte a = 4;
int b = a + 70;
//Результатом операции вполне справедливо является число 74, как и ожидается.

//Но теперь попробуем применить сложение к двум объектам типа byte:


byte a = 4;
byte b = a + 70;  // ошибка

//Здесь поменялся только тип переменной, которая получает результат сложения - с int на byte.
//    Однако при попытке скомпилировать программу мы получим ошибку на этапе компиляции. И если
//    мы работаем в Visual Studio, среда подчеркнет вторую строку красной волнистой линией, указывая, что в ней ошибка.

//При операциях мы должны учитывать диапазон значений, которые может хранить тот или
//иной тип. Но в данном случае число 74, которое мы ожидаем получить, вполне укладывается
//в диапазон значений типа byte, тем не менее мы получаем ошибку.

//Дело в том, что операция сложения (да и вычитания) возвращает значение типа int,
//    если в операции участвуют целочисленные типы данных с разрядностью меньше или равно
//    int (то есть типы byte, short, int). Поэтому результатом операции a + 70 будет объект,
//    который имеет длину в памяти 4 байта. Затем этот объект мы пытаемся присвоить переменной
//    b, которая имеет тип byte и в памяти занимает 1 байт.

//И чтобы выйти из этой ситуации, необходимо применить операцию преобразования типов:

byte a = 4;
byte b = (byte)(a + 70);

//Операция преобразования типов предполагает указание в скобках того типа, к которому надо преобразовать значение.

//Сужающие и расширяющие преобразования
//Преобразования могут сужающие (narrowing) и расширяющие(widening). Расширяющие
//    преобразования расширяют размер объекта в памяти. Например:

byte a = 4;             // 0000100
ushort b = a;   // 000000000000100

//В данном случае переменной типа ushort присваивается значение типа byte. Тип byte занимает 1 байт
//    (8 бит), и значение переменной a в двоичном виде можно представить как:


//00000100
//Значение типа ushort занимает 2 байта (16 бит). И при присвоении переменной b значение переменной a расширяется до 2 байт


//0000000000000100
//То есть значение, которое занимает 8 бит, расширяется до 16 бит.

//Сужающие преобразования, наоборот, сужают значение до типа меньшей разядности. Во
//втором листинге статьи мы как раз имели дело с сужающими преобразованиями:

ushort a = 4;
byte b = (byte)a;

//Здесь переменной b, которая занимает 8 бит, присваивается значение ushort, которое занимает 16 бит. То
//    есть из 0000000000000100 получаем 00000100. Таким образом, значение сужается с 16 бит (2 байт) до 8 бит(1 байт).

//Явные и неявные преобразования
//Неявные преобразования
//В случае с расширяющими преобразованиями компилятор за нас выполнял все преобразования данных, то есть
//преобразования были неявными (implicit conversion). Такие преобразования не вызывают каких-то затруднений.
//    Тем не менее стоит сказать пару слов об общей механике подобных преобразований.

//Если производится преобразование от безнакового типа меньшей разрядности к безнаковому типу
//    большой разрядности, то добавляются дополнительные биты, которые имеют значени 0. Это называется
//    дополнение нулями или zero extension.


byte a = 4;             // 0000100
ushort b = a;   // 000000000000100

//Если производится преобразование к знаковому типу, то битовое представление дополняется нулями,
//    если число положительное, и единицами, если число отрицательное. Последний разряд числа содержит
//    знаковый бит - 0 для положительных и 1 для отрицательных чисел. При расширении в добавленные
//    разряды компируется знаковый бит.

//Рассмотрим преобразование положительного числа:


sbyte a = 4;            // 0000100
short b = a;    // 000000000000100


sbyte a = -4;           // 1111100
short b = a;    // 111111111111100

int a = 4;
int b = 6;
byte c = (byte)(a + b);


double a = 4.0;
decimal b = (decimal)a;

int a = 33;
int b = 600;
byte c = (byte)(a + b);


try
{
    int a = 33;
    int b = 600;
    byte c = checked((byte)(a + b));
    Console.WriteLine(c);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}