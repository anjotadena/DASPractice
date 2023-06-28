namespace DSAPractice.ArrayAndHashing;

public class ContainsDuplicate : ISolution
{
    public string Title => "Contains Duplicate";

    public bool Execute()
    {
        var nums = new[] {1, 2, 45, 3};

        HashSet<int> set = new HashSet<int>();

        foreach (int n in nums)
        {
            if (set.Contains(n))
            {
                return true;
            }

            set.Add(n);
        }

        return false;
    }

    public string Answer()
    {
        var isCorrect = Execute();

        return $"Answer: {(isCorrect ? "Correct" : "Not Correct")}";
    }

}
