using System;
using System.Collections.Generic;
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

            var temp = Directory.GetDirectories(path);
            IEnumerable<string> temper = Directory.GetDirectories(path);
            foreach (var item in temper)
            {
                result.Add(item);
            }
            //result = result.Concat(temper);
            foreach (var item in temp)
            {
                FindAllFolders(item, result);
            }

        }

    }
}
