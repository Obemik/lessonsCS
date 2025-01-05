namespace Delegate;

public class Calculate
{
    public delegate void Operation(double a, double b);

    public Operation? MakeAction { set; get; }

    public Calculate(params char[] operation)
    {
        MakeAction = null;
        foreach (var item in operation)
        {
            switch (item)
            {
                case '+':
                    if (MakeAction == null)
                    {
                        MakeAction = Add;
                    }
                    else
                    {
                        MakeAction += Add;
                    }
                    break;
                case '-':
                    if (MakeAction == null)
                    {
                        MakeAction = Subtract;
                    }
                    else
                    {
                        MakeAction += Subtract;
                    }
                    break;
                case '*':
                    if (MakeAction == null)
                    {
                        MakeAction = Multiply;
                    }
                    else
                    {
                        MakeAction += Multiply;
                    }
                    break;
                case '/':
                    if (MakeAction == null)
                    {
                        MakeAction = Divide;
                    }
                    else
                    {
                        MakeAction += Divide;
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }

    void Add(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    void Subtract(double a, double b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    void Multiply(double a, double b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    void Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        Console.WriteLine($"{a} / {b} = {a / b}");
    }
}