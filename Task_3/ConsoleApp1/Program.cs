namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            try
            {
                CheckForVowels(input);
                Console.WriteLine("The string contains vowels.");
            }
            catch (NoVowelsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void CheckForVowels(string input)
        {
            if (!ContainsVowels(input))
            {
                throw new NoVowelsException("The string does not contain any vowels.");
            }
        }
        static bool ContainsVowels(string input)
        {
            return input.ToLower().Intersect("aeiou").Any();
        }
    }
}
class NoVowelsException : Exception
{
    public NoVowelsException(string message) : base(message)
    {
    }
}
