namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of integers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbersAsString = input.Split(' ');
            try
            {
                HashSet<int> uniqueNumbers = new HashSet<int>();
                foreach (string numberAsString in numbersAsString)
                {
                    int number = int.Parse(numberAsString);
                    if (!uniqueNumbers.Add(number))
                    {
                        throw new InvalidOperationException("Duplicate numbers are not allowed.");
                    }
                }
                Console.WriteLine("No duplicates found. All numbers are unique.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter integers separated by spaces.");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}