
namespace _02._Line_Numbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp2
    {
       public static void Main()
        {
            var textLines = File.ReadAllLines("text.txt");

            var lineCounter = 1;

            foreach (var item in textLines)
            {
                var letterCounter = item.Count(char.IsLetter);
                var punctCounter = item.Count(char.IsPunctuation);

                File.AppendAllText("output.txt",$"Line {lineCounter}: {item} ({letterCounter})({punctCounter}){Environment.NewLine}");

                lineCounter++;

            }
        }
    }
}
