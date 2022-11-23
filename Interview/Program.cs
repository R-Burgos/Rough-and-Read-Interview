using System.Globalization;

namespace Interview
{
    public class Program
    {
        const string csvPath = "Interview_Questions.csv";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Fellow TrueCoder classmates, I hope you find this little console app to be a useful \ntool when studying some of these interview questions.");
            Console.WriteLine("I wanted the questions to be presented without the answer right under them.");
            Console.WriteLine("Some of the answers are long... sorry for the formating!  If I have time I may update \nthis or maybe an aspiring classmate will for me...????");
            Console.WriteLine("There will be a question followed by a Console.ReadLine(), press enter to reveal the answer.");
            Console.WriteLine("Good Luck!\n");
            Console.WriteLine("*--------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("Press anything to continue...");
            Console.ReadLine();

            var lines = File.ReadAllLines(csvPath);
            var parser = new Parser();

            var x = lines.Select(parser.Parse).ToArray();

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}