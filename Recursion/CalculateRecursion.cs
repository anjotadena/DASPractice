namespace DSAPractice.Recursion;

public class CalculateRecursion : ISolution
{
    public string Title => "Calculate Recursion Example";

    public static int Calculate(int n)
    {
        if (n > 0)
        {
            return n + Calculate(n - 1);
        }

        return n;
    }

    public string Answer()
    {
        int total = Calculate(5);

        return $"Result: {total}";
    }
}
