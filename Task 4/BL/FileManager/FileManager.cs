using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FileManager
    {
        public void FindAllFolders(string path, List<string> result)
        {
            if (result.Where(x =>x == path).Count() == 0)
            {
                result.Add(path);  
            }
            var temp = Directory.GetDirectories(path);
            IEnumerable<string> temper = Directory.GetDirectories(path);
            foreach (var item in temper)
            {
                result.Add(item);
            }
            foreach (var item in temp)
            {
                FindAllFolders(item, result);
            }

        }
        public IList<string> FindAllFiles(IList<string> listPathFolder) 
        {
            List<string> listPathFile = new List<string>();
            string maskSearch = "*." + ConfigurationManager.AppSettings["FormatFile"]; //маска  поиска файлов заданного формата
            foreach (var item in listPathFolder)
            {
                var tempResult = Directory.GetFiles(item, maskSearch);
                foreach (var pathFile in tempResult)
                {
                   listPathFile.Add(pathFile ); 
                }
            }
            return listPathFile;
        }
        public string GetNameFile(string pathFile)
        {
            return Path.GetFileNameWithoutExtension(pathFile);
        }

    }
}
