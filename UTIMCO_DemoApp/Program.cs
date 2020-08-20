using System;

namespace UTIMCO_DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileReader fileReaderController = new FileReader(args);
            fileReaderController.Process();

            Console.Write("\n Click any key to exit...");
            Console.ReadLine();

            Environment.Exit(0);
        }
    }
}
