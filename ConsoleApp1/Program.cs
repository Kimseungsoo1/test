using System.Net.Sockets;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static float Add(float a, float b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        int sum1 = Add(10, 20);
        float sum2 = Add(10.5f, 20.2f);
        int sum3 = Add(10, 20, 30);
        
        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);
    }
    
}
