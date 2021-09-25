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

                if (IsFileExists(path, Messages.Argument.GetString()))
                {
                    return Content;
                }
            }

            Console.WriteLine(Messages.Input.GetString());

            while (true)
            {
                path = Console.ReadLine();

                if (path == "0")
                {
                    path = Path.GetFullPath(@"..\..\..\") + "example.txt";

                    if (IsFileExists(path, Messages.Example.GetString()))
                    {
                        return Content;
                    }

                    return String.Empty;
                } 
                else
                {
                    if (IsFileExists(path, Messages.ReInput.GetString()))
                    {
                        return Content;
                    }
                }
            }
        }

        public void OutputResults(int maxStringNumber, int[] falseStringNumbers)
        {
            if (falseStringNumbers != null)
            {
                if (maxStringNumber > 0)
                {
                    Console.WriteLine(String.Format(Messages.MaxSum.GetString(), maxStringNumber));
                }

                if (falseStringNumbers.Length > 0)
                {
                    foreach (int number in falseStringNumbers)
                    {
                        Console.WriteLine(String.Format(Messages.FalseString.GetString(), number));
                    }
                }
            }
            else
            {
                Console.WriteLine(Messages.Empty.GetString());
            }
        }

        private bool IsFileExists(string path, string message)
        {
            if (File.Exists(path))
            {
                Content = File.ReadAllText(path);

                return true;
            }
            else
            {
                Console.WriteLine(message);

                return false;
            }
        }
    }
}
