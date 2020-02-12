
namespace _06._Zip_and_Extract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class StartUp6
    {
       public static void Main()
        {
            var picFolderPath = "copyMe.png";
            var targetPath = @"..\..\myNewZip.zip";

            //ZipFile.CreateFromDirectory(picFolderPath, targetPath);

            //ZipFile.ExtractToDirectory(targetPath, "../../");

                using (var archive= ZipFile.Open(targetPath,ZipArchiveMode.Create))
                {
                archive.CreateEntryFromFile(picFolderPath, Path.GetFileName(picFolderPath));
                }
        }
    }
}
