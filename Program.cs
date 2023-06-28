﻿using DSAPractice.ArrayAndHashing;

namespace DSAPractice;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data structure and Algorithms | Practice");

        ISolution[] solutions = new ISolution[]
        {
            new ContainsDuplicate(),
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