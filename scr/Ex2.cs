class Ex2
{
    public static void Run()
    {
        Random rand = new Random();
        Func<int>[] delegates = new Func<int>[]
        {
                () => rand.Next(10),
                () => rand.Next(20),
                () => rand.Next(30)
        };

        Func<Func<int>[], double> avg = delegate (Func<int>[] functions)
        {
            int sum = 0;
            foreach (var func in functions)
            {
                sum += func();
            }
            return (double)sum / functions.Length;
        };

        double result = avg(delegates);

        Console.WriteLine($"Середнє: {result}");
    }
}
