using BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserFiles
{
    class Program
    {
        static void Main(string[] args)
        {
             string pathInput = ConfigurationManager.AppSettings["InputFolder"];
            FileSystemWatcher watcher = new FileSystemWatcher(pathInput);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            
            watcher.EnableRaisingEvents = true;
            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();
            
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            string pathInput = ConfigurationManager.AppSettings["InputFolder"];
            string pathOutput = ConfigurationManager.AppSettings["OutputFolder"];
            FileManager fileManager = new FileManager();
            List<string> resultFolder = new List<string>();
            fileManager.FindAllFolders(pathInput, resultFolder);
            var result = fileManager.FindAllFiles(resultFolder);
            Parser parser = new Parser();
            InputFileManager inputFileManager = new InputFileManager();
            foreach (var item in result)
            {
                var parseNameFile = parser.ParseNameFile(fileManager.GetNameFile(item));
                var parseFile = parser.ParseFile(item);
                inputFileManager.AddInputFile(parseNameFile, parseFile);
                fileManager.MoveFile(item, pathOutput);
                Console.WriteLine(fileManager.GetNameFile(item) + " - обработан");
            }
        }
    }
}
