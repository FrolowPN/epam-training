using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Parser
    {
        public InputFileWievModel ParseNameFile(string nameFile)
        {
            string[] partsNameFile = nameFile.Split('_');
            int nameManager = 0; // имя менеджера первая часть имени файла
            int dateFile = 1; //дата файла вторая часть имени файла
            InputFileWievModel result = new InputFileWievModel()
                                                                {
                                                                    NameManager = partsNameFile[nameManager],
                                                                    DateFile = ConvertToDate(partsNameFile[dateFile])
                                                                };
            return result;
        }
         DateTime ConvertToDate(string date) //дата принимается строкой вида ДДММГГГГ
        {
            string result = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (i == 3 || i == 6) //преобразуем входящую строку в ДД-ММ-ГГГГ
                {
                    result += "-" + date[i];
                }
                else 
                {
                    result +=  date[i];
                }
            }
            return DateTime.Parse(result);
        }
    }
}
