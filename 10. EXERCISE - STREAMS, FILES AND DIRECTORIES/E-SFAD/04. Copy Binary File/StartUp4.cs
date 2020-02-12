
namespace _04._Copy_Binary_File
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var picPath = "copyMe.png";
            var picCopyPath = "copyMe-copy.png";

            using (var streamReader = new FileStream(picPath, FileMode.Open))
            {
                using (var streamWriter = new FileStream(picCopyPath, FileMode.Create))
                {
                    while (true)
                    {
                        var byteArray = new byte[4096];

                        var size = streamReader.Read(byteArray, 0, byteArray.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        streamWriter.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}
