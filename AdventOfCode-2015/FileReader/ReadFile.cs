using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2015.FileReader
{
      class ReadFile
    {
        private string content;
        public ReadFile(int dayNumber)
        {
            content = System.IO.File.ReadAllText("Data/Day" + dayNumber + "/input.txt");
        }
        public string GetFileContent()
        {
            return content;
        }

    }
}
