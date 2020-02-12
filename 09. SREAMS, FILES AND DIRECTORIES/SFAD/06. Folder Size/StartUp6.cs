
namespace _06._Folder_Size
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            //Directory.CreateDirectory("Temp");
            //File.WriteAllText(@"Temp\Output.txt", "Това е целият текст You are stupid!");
            //var files = Directory.GetFiles("Temp");
            //var fileInfo = new FileInfo(files[0]);
            //Console.WriteLine(fileInfo.FullName);
            //Console.WriteLine(fileInfo.Name);
            //Console.WriteLine(fileInfo.Length);
            //Console.WriteLine(File.ReadAllText(fileInfo.FullName));
            //
            //using (var ms = new MemoryStream(Encoding.UTF8.GetBytes("Здравей GZIP!")))
            //{
            //    using (var fs = new FileStream("Test.gz", FileMode.Create))
            //    {
            //        using (var gz = new GZipStream(fs, CompressionLevel.Optimal))
            //        {
            //            ms.CopyTo(fs);
            //        }
            //    }
            //}
            var files = Directory.GetFiles("TestFolder");
            double sum = 0;
            foreach (var item in files)
            {
                var fileInfo = new FileInfo(item);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("Output.txt",sum.ToString());
        }
    }
}
