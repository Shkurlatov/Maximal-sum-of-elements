using ParsingProject;

namespace SumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInterface console = new ConsoleInterface();

            Parsing parsing = new Parsing(console.GetFileContent(args));

            console.OutputResults(parsing);
        }
    }
}
