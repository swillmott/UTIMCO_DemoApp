using System;

namespace UTIMCO_DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileReaderController fileReaderController = new FileReaderController(args);
            fileReaderController.Process();

            Console.Write("\n Click any key to exit...");
            Console.ReadLine();

            Environment.Exit(0);
        }
    }
}
