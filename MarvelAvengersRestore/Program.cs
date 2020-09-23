namespace MarvelAvengersRestore
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var sourceFolder = @"c:\\MarvelAvengersBackup";
            var destinationFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Marvel's Avengers";

            if (!Directory.Exists(sourceFolder))
            {
                return;
            }

            var di = new DirectoryInfo(sourceFolder);
            var latestBackup = di.GetFiles("*-MarvelAvengersBackup.zip", SearchOption.TopDirectoryOnly).OrderByDescending(c => c.LastWriteTime).FirstOrDefault();

            if (latestBackup != null)
            {
                Console.WriteLine($"The latest backup found is {latestBackup.Name}. Are you sure you want to overwrite your local saves with this?");
                var keyPressed = Console.ReadKey(false);
                if (keyPressed.Key == ConsoleKey.Y)
                {
                    ZipFile.ExtractToDirectory(latestBackup.FullName, destinationFolder, true);
                }
                
            }
        }
    }
}
