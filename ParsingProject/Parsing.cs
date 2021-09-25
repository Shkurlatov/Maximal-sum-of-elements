using System;
using System.Collections.Generic;
using System.Linq;

namespace ParsingProject
{
    public class Parsing
    {
        public int MaxStringNumber { get; private set; }
        public int[] FalseStringNumbers { get; private set; }

        public Parsing(string content)
        {
            if (content != null && content.Length > 0)
            {
                SearchContent(content);
            }
        }

        private void SearchContent(string content)
        {
            List<int> falseStringNumbers = new List<int>();
            double maxStringValue = Double.MinValue;

            string[] strings = content.Split('\n');

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Any(char.IsLetter) || strings[i].Contains(' ') || strings[i].Contains('\t'))
                {
                    falseStringNumbers.Add(i + 1);
                    continue;
                }

                double stringValue = 0;
                string[] segments = strings[i].Split(',');

                for (int j = 0; j < segments.Length; j++)
                {
                    if (Double.TryParse(segments[j], out double value))
                    {
                        stringValue += value;

                        if (j == segments.Length - 1)
                        {
                            if (stringValue >= maxStringValue)
                            {
                                maxStringValue = stringValue;
                                MaxStringNumber = i + 1;
                            }
                        }
                    }
                    else
                    {
                        falseStringNumbers.Add(i + 1);
                        break;
                    }
                }
            }

            FalseStringNumbers = falseStringNumbers.ToArray();
        }
    }
}
