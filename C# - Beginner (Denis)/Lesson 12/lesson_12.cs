
for (int i = 0; i < 9; i++)
{
    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
}

int i = 0;
for (; ; )
{
    Console.WriteLine($"Квадрат числа {++i} равен {i * i}");
}
int i = 0;
for (; i < 9;)
{
    Console.WriteLine($"Квадрат числа {++i} равен {i * i}");
}

int i = 6;
do
{
    Console.WriteLine(i);
    i--;
}
while (i > 0);


int i = -1;
do
{
    Console.WriteLine(i);
    i--;
}
while (i > 0);


int i = 6;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}


for (int i = 0; i < 9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}