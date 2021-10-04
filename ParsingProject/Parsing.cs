using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ParsingProject
{
    public class Parsing
    {
        public bool IsFileEmpty { get; private set; }
        public int MaxStringNumber { get; private set; }
        public List<int> FalseStringNumbers { get; private set; }

        public Parsing(string content)
        {
            if (!String.IsNullOrEmpty(content))
            {
                IsFileEmpty = false;
                FalseStringNumbers = new List<int>();
                SearchContent(content);
            }
            else
            {
                IsFileEmpty = true;
            }
        }

        private void SearchContent(string content)
        {
            double maxStringValue = Double.MinValue;
            string[] lines = content.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Any(char.IsLetter))
                {
                    FalseStringNumbers.Add(i + 1);
                    continue;
                }

                double stringValue = 0;
                string[] section = lines[i].Split(',');

                for (int j = 0; j < section.Length; j++)
                {
                    if (Double.TryParse(section[j], NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                    {
                        stringValue += value;
                    }
                    else
                    {
                        FalseStringNumbers.Add(i + 1);
                        break;
                    }
                }

                if (!FalseStringNumbers.Contains(i + 1) && stringValue >= maxStringValue)
                {
                    maxStringValue = stringValue;
                    MaxStringNumber = i + 1;
                }
            }
        }
    }
}
