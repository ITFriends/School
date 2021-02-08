static int Factorial(int x)
{
    if (x == 0)
    {
        return 1;
    }
    else
    {
        return x * Factorial(x - 1);
    }
}

static int Fibonachi(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return Fibonachi(n - 1) + Fibonachi(n - 2);
    }
}

static int Fibonachi(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    else
    {
        return Fibonachi(n - 1) + Fibonachi(n - 2);
    }
}

static int Fibonacci(int n)
{
    int a = 0;
    int b = 1;
    int tmp;

    for (int i = 0; i < n; i++)
    {
        tmp = a;
        a = b;
        b += tmp;
    }

    return a;
}