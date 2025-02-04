void PrintLine()
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write("=");
    }
    Console.WriteLine();
}

void PrintLine2(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write("=");
    }
    Console.WriteLine();
}

int Add(int a, int b)
{
    return a + b;
}

PrintLine();
PrintLine2(5);

int result = Add(10, 20);
Console.WriteLine(result);