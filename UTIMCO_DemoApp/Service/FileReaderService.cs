using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace UTIMCO_DemoApp
{
    public class FileReaderService
    {
        private string _filepath;
        private ExtOutputSummary _outputSummary; 
        public FileReaderService(string filepath)
        {
            _filepath = Path.GetFullPath(filepath);
            //TO-DO: If filepath is empty
            //Check that user has permissions to filepath
            _outputSummary = new ExtOutputSummary();
        }

        public void ReadFile()
        {
            if (Path.GetExtension(_filepath) != ".json") {
                Console.WriteLine("File is not in JSON format");
                return;
            } 

            try
            {
     

                using (StreamReader sr = new StreamReader(_filepath))
                {
                    string jsonInput = sr.ReadToEnd();

                    List<Menu> menus = JsonConvert.DeserializeObject<List<Menu>>(jsonInput);

                    foreach(Menu tempMenu in menus)
                    {
                        int sumIds = 0;
                        foreach (Items tempItem in tempMenu.menu.items)
                        {
                            
                            if(tempItem != null && tempItem.label != null)
                            {
                                sumIds += tempItem.id;
                            }


                        };
                        _outputSummary.IdSumList.Add(sumIds);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("File cannot be read:" + _filepath);
            }

        }
        public string Result()
        {
            return _outputSummary.PrintSumList();
        }
    }
}
