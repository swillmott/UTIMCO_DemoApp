using System;
using System.Collections.Generic;
using System.Text;

namespace UTIMCO_DemoApp.Tests.Controller
{
    public class FileReaderShould
    {
        private FileReader fileReader;

        public FileReaderShould()
        {
            string[] args = {"EmptyPath.txt"};
            fileReader = new FileReader(args);
        }


    }
}
