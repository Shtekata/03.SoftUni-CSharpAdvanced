
namespace _01._Odd_Lines
{
    using System;
    using System.IO;

    public class StartUp1
    {
        public static void Main()
        {
            string path = "Files";
            string fileName = "Input.txt";
            string filePath = Path.Combine(path, fileName);

            using (var input = new StreamReader(filePath))
            {
                int counter = 0;

                var line = input.ReadLine();

                string outputName = "Output.txt";
                string outputPath = Path.Combine(path, outputName);

                using (var output = new StreamWriter(outputPath))
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            output.WriteLine(line);
                            Console.WriteLine(line);
                        }
                        counter++;
                        line = input.ReadLine();
                    }
                }
            }
        }
    }
}
