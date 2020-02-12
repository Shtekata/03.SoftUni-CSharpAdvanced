
namespace _02._Line_Numbers
{
    using System;
    using System.IO;

    public class StartUp2
    {
        public static void Main()
        {
            var directory = "Files";
            var file = "Input.txt";
            var path = Path.Combine(directory, file);

            using (var input = new StreamReader(path))
            {
                using (var output = new StreamWriter(Path.Combine(directory, "Output.txt")))
                {
                    string line;
                    int number = 1;
                    while ((line = input.ReadLine()) != null)
                    {
                        output.WriteLine($"{number++}. {line}");
                    }
                }
            }
        }
    }
}
