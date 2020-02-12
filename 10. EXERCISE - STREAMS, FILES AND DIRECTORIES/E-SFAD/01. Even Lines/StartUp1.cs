
namespace _01._Even_Lines
{
    using System;
    using System.IO;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            var textFilePath = @"..\..\..\text.txt";
            var counter = 0;
            var outputFilePath = "result.txt";

            using (var streamWriter=new StreamWriter(outputFilePath))
            {
                using (var streamReader = new StreamReader(textFilePath))
                {
                    var currentLine = streamReader.ReadLine();
                    while (currentLine != null)
                    {
                        if (counter % 2 == 0)
                        {
                            var replacedSymbols = ReplaceSpecialCharacters(currentLine);
                            var reversedWords = ReversedWords(replacedSymbols);

                            streamWriter.WriteLine(reversedWords);
                        }
                        currentLine = streamReader.ReadLine();

                        counter++;
                    }
                }
            }
        }

        private static string ReversedWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSpecialCharacters(string currentLine)
        {
           return currentLine.Replace('-', '@')
                .Replace(',', '@')
                .Replace('.', '@')
                .Replace('!', '@')
                .Replace('?', '@');
        }
    }
}
