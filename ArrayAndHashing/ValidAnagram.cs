namespace DSAPractice.ArrayAndHashing;

public class ValidAnagram : ISolution
{
    string ISolution.Title => "Valid Anagram";

    public string Answer()
    {
        var s = "anagram";
        var t = "nagaram";

        if (s.Count() != t.Count())
        {
            return "Not Anagram!";
        }

        Dictionary<char, int> sCounts = new Dictionary<char, int>();
        Dictionary<char, int> tCounts = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sCounts[s[i]] =  1 + (sCounts.ContainsKey(s[i]) ? sCounts[s[i]] : 0);
            tCounts[t[i]] =  1 + (tCounts.ContainsKey(t[i]) ? tCounts[t[i]] : 0);
        }

        foreach (char c in sCounts.Keys)
        {
            int tCount = tCounts.ContainsKey(c) ? tCounts[c] : 0;

            if (sCounts[c] != tCount)
            {
                return $"Not anagram";
            }
        }


        return $"Valid Anagram";
    }
}
