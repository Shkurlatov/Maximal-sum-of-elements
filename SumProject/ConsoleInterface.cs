using ParsingProject;
using System;
using System.IO;

namespace SumProject
{
    public class ConsoleInterface
    {
        private string content;

        public string GetFileContent(string[] args)
        {
            string pathFromUser;

            if (args.Length > 0)
            {
                pathFromUser = String.Join(' ', args);

                if (IsFileExists(pathFromUser))
                {
                    return content;
                }

                Console.WriteLine(Messages.WrongArgsPath.GetString());
            }

            Console.WriteLine(Messages.PathInputRequest.GetString());

            while (true)
            {
                pathFromUser = Console.ReadLine();

                if (pathFromUser == "0")
                {
                    string pathToExample = "example.txt";

                    if (IsFileExists(pathToExample))
                    {
                        return content;
                    }

                    pathToExample = Path.GetFullPath(@"..\..\..\") + pathToExample;

                    if (IsFileExists(pathToExample))
                    {
                        return content;
                    }

                    Console.WriteLine(Messages.ExampleNotFound.GetString());
                    return String.Empty;
                }

                if (IsFileExists(pathFromUser))
                {
                    return content;
                }

                Console.WriteLine(Messages.WrongInputPath.GetString());
            }
        }

        public void OutputResults(Parsing parsing)
        {
            if (!parsing.IsFileEmpty)
            {
                if (parsing.MaxStringNumber > 0)
                {
                    Console.WriteLine(String.Format(Messages.MaxLineNumber.GetString(), parsing.MaxStringNumber));
                }

                if (parsing.FalseStringNumbers.Count > 0)
                {
                    foreach (int number in parsing.FalseStringNumbers)
                    {
                        Console.WriteLine(String.Format(Messages.FalseLinesNumbers.GetString(), number));
                    }
                }
            }
            else
            {
                Console.WriteLine(Messages.FileEmpty.GetString());
            }
        }

        private bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                content = File.ReadAllText(path);

                return true;
            }

            return false;
        }
    }
}
