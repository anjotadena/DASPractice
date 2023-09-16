namespace DSAPractice.Recursion;

internal class FactorialOfANumber : ISolution
{
    public string Title => "Factorial of a number";

    public string Answer()
    {
        var n = 4;
        var result = Calculate(n);

        return $"Factorial of {n} is {result}";
    }

    private int Calculate(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n * Calculate(n - 1);
    }
}
