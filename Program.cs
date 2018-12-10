using System;
using System.IO;

namespace directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

           var files = Directory.GetFiles(@"C:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\projects\CSharFundamentals", "*.*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
