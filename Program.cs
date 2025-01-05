namespace Delegate;

internal class Program
{
    static void Main()
    {
        double a = 10, b = 5;
        try
        {
            Calculate calc = new Calculate('+', '-', '*');
            calc.MakeAction?.Invoke(a, b);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine($"a = {a}, b = {b}");
        }


    }
}