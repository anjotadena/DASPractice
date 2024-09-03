using DSAPractice.ArrayAndHashing;
using DSAPractice.BitManipulation;
using DSAPractice.LinkedList;
using DSAPractice.Recursion;
using DSAPractice.Stack;
using System.Reflection;

namespace DSAPractice;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data structure and Algorithms | Practice");

        // get all solutions
        var solutionsTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(ISolution).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToList();

        for (int i = 0; i< solutionsTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {solutionsTypes[i].Name}");
        }

        Console.WriteLine("Select a solution to execute (enter the number): ");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= solutionsTypes.Count)
        {
            ISolution selectedSolution = (ISolution)Activator.CreateInstance(solutionsTypes[choice - 1])!;

            Console.WriteLine(selectedSolution.Answer());
        }
        else
        {
            Console.WriteLine("Invalid selection!");
        }
    }
}
