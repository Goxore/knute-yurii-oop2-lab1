class Ex1
{
    public static void Run()
    {
        Func<double, double, double> Add = (a, b) => a + b;
        Func<double, double, double> Sub = (a, b) => a - b;
        Func<double, double, double> Mul = (a, b) => a * b;

        Func<double, double, double> Div = (a, b) => b == 0 ? double.NaN : a / b;

        Console.Write("Введіть перше число: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть операцію (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine());

        double result;
        switch (op)
        {
            case '+':
                result = Add(a, b);
                break;
            case '-':
                result = Sub(a, b);
                break;
            case '*':
                result = Mul(a, b);
                break;
            case '/':
                result = Div(a, b);
                break;
            default:
                Console.WriteLine("Операція немолива.");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}
