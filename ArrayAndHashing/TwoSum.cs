using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.ArrayAndHashing
{
    public class TwoSum : ISolution
    {
        public string Title => "Two Sum";

        public string Answer()
        {
            var target = 5;
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            var indeces = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (indeces.ContainsKey(diff))
                {
                    return $"Has sum in index {indeces[diff]}, {i}";
                }
                indeces[nums[i]] = i;
            }

            return "No Sum!";
        }
    }
}
