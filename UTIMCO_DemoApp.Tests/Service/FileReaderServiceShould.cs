using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;

namespace UTIMCO_DemoApp.Tests.Service
{
    public class FileReaderServiceShould
    {
        private FileReaderService fileReaderService;

        public FileReaderServiceShould()
        {
        }

        [Theory]
        [InlineData(".\\Service\\TestFiles\\TestFile1.txt", "")]
        [InlineData(".\\Service\\TestFiles\\TestFile3.json", "")]
        [InlineData(".\\Service\\TestFiles\\TestFile1.json", "46\r\n0\r\n248")]
        [InlineData(".\\Service\\TestFiles\\TestFile2.json", "0")]
        public void ReadFileShould(string filepath, string expected)
        {
            fileReaderService = new FileReaderService(filepath);

            fileReaderService.ReadFile();
            var result = fileReaderService.Result();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ResultShould()
        {
            fileReaderService = new FileReaderService("EmptyPath.txt");

            var result = fileReaderService.Result();

            Assert.Equal("", result);

        }
    }
}
