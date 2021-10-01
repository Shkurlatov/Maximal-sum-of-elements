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
        public int[] FalseStringNumbers { get; private set; }

        public Parsing(string content)
        {
            if (content != null && content.Length > 0)
            {
                IsFileEmpty = false;
                SearchContent(content);
            }
            else
            {
                IsFileEmpty = true;
            }
        }

        private void SearchContent(string content)
        {
            List<int> falseStringNumbers = new List<int>();
            double maxStringValue = Double.MinValue;
            string[] lines = content.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Any(char.IsLetter))
                {
                    falseStringNumbers.Add(i + 1);
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
                        falseStringNumbers.Add(i + 1);
                        break;
                    }
                }

                if (!falseStringNumbers.Contains(i + 1) && stringValue >= maxStringValue)
                {
                    maxStringValue = stringValue;
                    MaxStringNumber = i + 1;
                }
            }

            FalseStringNumbers = falseStringNumbers.ToArray();
        }
    }
}
