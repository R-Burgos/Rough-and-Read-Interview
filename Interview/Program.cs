using System.Globalization;

namespace Interview
{
    public class Program
    {
        const string csvPath = "Interview_Questions.csv";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("This will test you on the some of the interview questions that you may encounter.");
            Console.WriteLine("There will be a question followed by a Console.ReadLine(), press enter to reveal the answer.");
            Console.WriteLine("Good Luck!\n");
            Console.WriteLine("*--------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("Press anything to continue...");
            Console.ReadLine();

            var lines = File.ReadAllLines(csvPath);
            var parser = new Parser();

            var x = lines.Select(parser.Parse).ToArray();

        }
    }
}