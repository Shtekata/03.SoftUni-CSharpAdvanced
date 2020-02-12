
namespace _05._Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            var directoryInfo = new DirectoryInfo(".");

            var allFiles = directoryInfo.GetFiles();

            foreach (var item in allFiles)
            {
                var size = item.Length / 1024d;
                var name = item.Name;
                var extension = item.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }

                if (!dirInfo[extension].ContainsKey(name))
                {
                    dirInfo[extension].Add(name, size);
                }

            }

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            var sortedDictionary = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ThenBy(x => x.Value.Values)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (key, value) in sortedDictionary)
            {
                File.AppendAllText(path, key + Environment.NewLine);
                foreach (var (name, size) in value)
                {
                    File.AppendAllText(path, $"--{name} - {Math.Round(size,3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
