using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2015.Puzzle.Day2
{
    class Day2
    {
        private int totalWrapPaper;
        private int ribbonSize;
        public Day2(string content)
        {
            string[] line = content.Split('\n');
            for(int i = 0; i < line.Length; i++)
            {
                if (!String.IsNullOrEmpty(line[i]))
                {
                    int[] dimension = Array.ConvertAll(line[i].Split('x'), s => int.Parse(s));
                    CalculerWrapPaper(dimension[0], dimension[1], dimension[2]);
                    calculerRibbon(dimension[0], dimension[1], dimension[2]);
                }
                
            }
        }
        public void CalculerWrapPaper(int length, int width, int height)
        {
            int minArea = 0;
            int area1 = length * width;
            int area2 = length * height;
            int area3 = width * height;
            if(area1 < area2)
            {
                minArea = area1;
            }
            else
            {
                minArea = area2;
            }
            if (area3 < minArea)
            {
                minArea = area3;
            }
            this.totalWrapPaper +=  minArea + 2 * area1 + 2 * area2 + 2 * area3;
        }
        public void calculerRibbon(int width,int length, int height)
        {
            int minSide1 = 0;
            int minSide2 = 0;
            if(width < length)
            {
                minSide1 = width;
                if(length < height)
                {
                    minSide2 = length;
                }
                else
                {
                    minSide2 = height;
                }
            }
            else
            {
                minSide1 = length;
                if(width < height)
                {
                    minSide2 = width;
                }
                else
                {
                    minSide2 = height;
                }
            }
            this.ribbonSize += minSide1 * 2 + minSide2 * 2 + width * height * length;
        }
        public int GetTotalWrapPaper()
        {
            return this.totalWrapPaper;
        }
        public int GetRibbonSize()
        {
            return this.ribbonSize;
        }
    }
}
