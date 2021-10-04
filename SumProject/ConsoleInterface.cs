using ParsingProject;
using System;
using System.IO;

namespace SumProject
{
    public class ConsoleInterface
    {
        private string Content;

        public string GetFileContent(string[] args)
        {
            string path;

            if (args.Length > 0)
            {
                path = String.Join(' ', args);

                if (IsFileExists(path))
                {
                    return Content;
                }
                else
                {
                    Console.WriteLine(Messages.WrongArgsPath.GetString());
                }
            }

            Console.WriteLine(Messages.PathInputRequest.GetString());

            while (true)
            {
                path = Console.ReadLine();

                if (path == "0")
                {
                    path = Path.GetFullPath(@"..\..\..\") + "example.txt";

                    if (IsFileExists(path))
                    {
                        return Content;
                    }
                    else
                    {
                        Console.WriteLine(Messages.ExampleNotFound.GetString());
                        return String.Empty;
                    }
                } 
                else
                {
                    if (IsFileExists(path))
                    {
                        return Content;
                    }
                    else
                    {
                        Console.WriteLine(Messages.WrongInputPath.GetString());
                    }
                }
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
                Content = File.ReadAllText(path);

                return true;
            }

            return false;
        }
    }
}
