using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.BitManipulation;

public class SingleNumber : ISolution
{
    public string Title => "Single Number";

    public string Answer()
    {
        // inputs
        int[] nums = new int[] { 4, 1, 2, 1, 2 };

        var r = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            r ^= nums[i];
        }

        Console.Write(r);

        return $"{Title} => Answer: {r}";
    }
}
