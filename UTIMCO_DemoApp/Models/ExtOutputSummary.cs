using System;
using System.Collections.Generic;
using System.Text;

namespace UTIMCO_DemoApp
{
    public class ExtOutputSummary
    {
        public List<int> IdSumList { get; set; } = new List<int>();

        public string PrintSumList()
        {
            string output = string.Join("\r\n", IdSumList); 
            return output;
        }
    }
}
