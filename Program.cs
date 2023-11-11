using DSAPractice.ArrayAndHashing;
using DSAPractice.BitManipulation;
using DSAPractice.LinkedList;
using DSAPractice.Recursion;

namespace DSAPractice;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data structure and Algorithms | Practice");

        ISolution[] solutions = new ISolution[]
        {
            new ContainsDuplicate(),
            new ValidAnagram(),
            new TwoSum(),
            new GroupAnagrams(),
            new CalculateRecursion(),
            new SumOfNNumbers(),
            new FactorialOfANumber(),
            new TopKFrequent(),
            new ProductOfArrayExceptSelf(),
            new ValidSudoku(),
            // Bit Manipulation
            new SingleNumber(),

            // Linked List
            new ReverseLinkedList(),
        };

        // @TODO 
        // Add implementation for every class solution
        for (var i = 0; i < solutions.Length; i++)
        {
            var solution = solutions[i];

            Console.WriteLine($"{i + 1}: {solution.Title} => {solution.Answer()}");
        }
    }
}
