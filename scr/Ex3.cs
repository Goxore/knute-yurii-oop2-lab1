class Ex3
{
    public static void Run()
    {
        Func<int, int, int, double> avg = delegate (int a, int b, int c)
        {
            return (double)(a + b + c) / 3;
        };

        double result = avg(10, 20, 30);
        Console.WriteLine($"Середнє: {result}");
    }
}
