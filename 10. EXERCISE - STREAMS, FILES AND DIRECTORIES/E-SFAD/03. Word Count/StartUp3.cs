
namespace _03._Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var textLines = File.ReadAllLines("text.txt");
            var words = File.ReadAllLines("words.txt");

            var wordsInfo = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (!wordsInfo.ContainsKey(item))
                {
                    wordsInfo.Add(item, 0);
                }
            }

            foreach (var item in textLines)
            {
                var currentLineWords = item.ToLower()
                    .Split(new char[] { ' ', '-', ',', '?', '!', '.', '\'', ':', ';' });

                foreach (var item1 in currentLineWords)
                {
                    if (wordsInfo.ContainsKey(item1))
                    {
                        wordsInfo[item1]++;
                    }
                }
            }

            var actualResultPath = "actualResult.txt";
            var expectedResultPath = "expectedResult.txt";
            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText(actualResultPath, $"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }
        }
    }
}
