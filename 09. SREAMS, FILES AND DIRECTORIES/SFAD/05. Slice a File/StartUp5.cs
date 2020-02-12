
namespace _05._Slice_a_File
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var inputFile = new FileStream(@"Files\SliceMe.txt", FileMode.Open))
            {
                var size = inputFile.Length;
                var partSize = (long)Math.Ceiling((double)size / 4);

                for (int i = 1; i < 5; i++)
                {
                    var currentPieceSize = 0;

                    using (var outputFile = new FileStream($@"Files\Part-{i}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];

                        while (inputFile.Read(buffer, 0, buffer.Length) == buffer.Length)
                        {
                            currentPieceSize += buffer.Length;
                            outputFile.Write(buffer, 0, buffer.Length);
                            if (currentPieceSize >= partSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
