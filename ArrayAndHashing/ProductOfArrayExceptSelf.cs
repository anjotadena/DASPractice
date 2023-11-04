using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.ArrayAndHashing;

public class ProductOfArrayExceptSelf : ISolution
{
    public string Title => "Product of Array Except Self";

    public string Answer()
    {
        // input
        int[] inputs = new int[] { 1, 2, 3, 4 };

        int prefix = 1, postfix = 1;
        int[] results = new int[inputs.Length];

        for (int i = 0; i < inputs.Length; i++)
        {
            results[i] = prefix;

            prefix *= inputs[i];
        }

        for (int i = inputs.Length - 1; i >= 0; i--)
        {
            results[i] *= postfix;

            postfix *= inputs[i];
        }

        return $"{Title} => Answer | {results.ToString()}";
    }
}
