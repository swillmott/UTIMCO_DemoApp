using System.Collections.Generic;
using Xunit;

namespace UTIMCO_DemoApp.Tests
{
    public class ExtOutputSummaryShould
    {
        private readonly ExtOutputSummary _outputSummary;

        public ExtOutputSummaryShould()
        {
            _outputSummary = new ExtOutputSummary();
        }

        [Fact]
        public void PrintSumList_Should()
        {
            var testList = new List<int>() { -1, 5, 10 };
            var expected = string.Join("\r\n", testList);

            _outputSummary.IdSumList.AddRange(testList);
            var resultString = _outputSummary.PrintSumList();

            Assert.Equal(expected, resultString);
        }
    }
}
