using System.Reflection;

namespace DSAPractice;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Data structure and Algorithms Collections");

        var exit = false;

        // get all solutions
        do
        {
            var solutionTypes = GetAllProblems();

            Console.Write("Select a solution to execute (enter the number): ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice >= solutionTypes.Count)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid selection! Please select [1-{solutionTypes.Count}]");
                Console.ResetColor();
                continue;
            }
            ISolution selectedSolution = (ISolution)Activator.CreateInstance(solutionTypes[choice - 1])!;

            Console.WriteLine("-------------------ANSWER------------------");
            Console.WriteLine(selectedSolution.Answer());

            Console.Write("\nDo you want to try another problem again? [Any key to continue or Esc to exit] ");

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nExiting application. Goodbye!");
                exit = true;
            } else
            {
                Console.Clear();
            }
        } while (!exit);
    }

    static private IList<Type> GetAllProblems()
    {
        var solutionsTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(ISolution).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToList();

        for (int i = 0; i < solutionsTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {solutionsTypes[i].Name}");
        }

        return solutionsTypes;
    }
}
