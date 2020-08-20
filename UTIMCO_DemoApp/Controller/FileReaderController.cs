using System;
using System.Collections.Generic;
using System.Text;

namespace UTIMCO_DemoApp
{
    public class FileReaderController
    {
        string filepath;
        public FileReaderController(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter Input Filepath: ");
                filepath = Console.ReadLine();
            }
            else
            {
                filepath = args[0];
            }
        }

        public void Process()
        {
            FileReaderService fileReaderService = new FileReaderService(filepath);
            fileReaderService.ReadFile();
            Console.Write(fileReaderService.Result());
        }
    }
}
