
using System.Text;

namespace DSAPractice.Problems
{
    public class DigitsToBinary : ISolution
    {
        public string Title => GetType().Name;

        private readonly int EIGHT_BITS = 8;

        public string Answer()
        {
            do
            {
                Console.Write("Input digit number: ");
                if (int.TryParse(Console.ReadLine(), out int inputValue))
                {
                    StringBuilder binary = new StringBuilder(string.Empty);

                    int absoluteNumber = Math.Abs(inputValue); // handle negative number

                    while (absoluteNumber > 0)
                    {
                        int remainder = absoluteNumber % 2; // since binary is base-2 number system, meaning each digit in binary number is either 0 or 1
                        binary.Insert(0, remainder);
                        absoluteNumber /= 2;

                        // Handle negative number
                        if (inputValue < 0)
                        {
                            binary.Insert(0, "-");
                        }
                    }

                    string result = binary.ToString().PadLeft(EIGHT_BITS, '0');

                    Console.WriteLine($"Binary representation of {inputValue} is {result}");
                    Console.Write("\nDo you want to try again? [Any key to continue or Esc to exit] ");

                    ConsoleKey key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.Escape)
                    {
                        return string.Empty;
                    }
                    
                }

                Console.WriteLine($"Invalid input {inputValue}. Please Try Again!");
            } while (true);
        }
    }
}
