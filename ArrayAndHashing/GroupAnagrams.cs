namespace DSAPractice.ArrayAndHashing
{
    public class GroupAnagrams : ISolution
    {

        public string Title => "Group Anagrams";

        public string Answer()
        {
            string[] strs = new[] { "tan", "tea", "any", "ant" };

            var groups = new Dictionary<string, IList<string>>();

            foreach (string s in strs)
            {
                char[] hash = new char[26]; // 26 character

                foreach (char c in s)
                {
                    hash[c - 'a']++;
                }

                string key = new string(hash);

                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }

                groups[key].Add(s);
            }

            //return groups.Values.ToList();

            return "No actual answer for now!";
        }
    }
}
