using DA;
using System;
using System.Collections.Generic;
using System.IO;
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
            int nameManager = 0;                                        // имя менеджера первая часть имени файла
            int dateFile = 1;                                          //дата файла вторая часть имени файла
            InputFileWievModel result = new InputFileWievModel()
                                                                {
                                                                    NameManager = partsNameFile[nameManager],
                                                                    DateFile = ConvertToDate(partsNameFile[dateFile])
                                                                };
            return result;
        }

        public IList<OrderWievModel> ParseFile(string path)
        {
            List<string> stringFile = new List<string>();
            List<OrderWievModel> result = new List<OrderWievModel>();
            using ( StreamReader file = new StreamReader(path))
            {
                string tempString = file.ReadLine();
                while (tempString != null)
                {
                    stringFile.Add(tempString); 
                }
            }
            foreach (var item in stringFile)
            {
                string[] partsString = item.Split(',');
                int datePart = 0;
                int clientPart = 0;
                int productPart = 0;
                int costPart = 0;
                OrderWievModel orderWM = new OrderWievModel()
                                                            {
                                                                DateOrder = ConvertToDate(partsString[datePart]),
                                                                NameClient = partsString[clientPart],
                                                                Product = partsString[productPart],
                                                                CostProduct = Convert.ToDouble(partsString[costPart])
                                                            };
                result.Add(orderWM);

            }
            return result;

        }

         DateTime ConvertToDate(string date)                        //дата принимается строкой вида ДДММГГГГ
        {
            string result = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (i == 3 || i == 6)                              //преобразуем входящую строку в ДД-ММ-ГГГГ
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
