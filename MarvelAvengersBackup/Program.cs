namespace MarvelAvengersBackup
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class Program
    {
        public static void Main(string[] args)
        {
            var source = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Marvel's Avengers";
            var destinationFolder = @"c:\\MarvelAvengersBackup";
            var destination = $"{destinationFolder}\\{DateTime.Now:yyyy-MM-dd HH-mm-ss}-MarvelAvengersBackup.zip";

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            ZipFile.CreateFromDirectory(source, destination);
        }
    }
}
