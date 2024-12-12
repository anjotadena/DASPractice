using System.Text.RegularExpressions;

namespace DSAPractice
{
    public class Utils
    {
        public static string ToHumanReadable(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "--- No Value ---";
            }

            return Regex.Replace(value, "(?<!^)([A-Z])", " $1");
        }
    }
}
