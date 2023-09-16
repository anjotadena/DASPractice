namespace DSAPractice.Recursion;

public class SumOfNNumbers : ISolution
{
    public string Title => "Sum of N Numbers";

    public string Answer()
    {
        var n = 5;
        var result = Calculate(n);
        return $"Sum of {n} is {result}";
    }

    private int Calculate(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n + Calculate(n - 1);
    }
}
