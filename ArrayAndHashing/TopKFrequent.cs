using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.ArrayAndHashing;

public class TopKFrequent : ISolution
{
    public string Title => "Top K Frequent Elements";

    public string Answer()
    {
        // inputs
        int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
        int k = 2;

        // Solutions
        int[] arr = new int[k];
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // it doesn't exist then set to 0
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 0);
            }

            dict[nums[i]]++;
        }

        var q = new PriorityQueue<int, int>();

        foreach (var key in dict.Keys)
        {
            q.Enqueue(key, dict[key]);

            if (q.Count > k)
            {
                q.Dequeue();
            }
        }

        int i2 = k;

        while (q.Count > 0)
        {
            arr[--i2] = q.Dequeue();
        }

        // return arr;

        return "Result array: ";
    }
}
