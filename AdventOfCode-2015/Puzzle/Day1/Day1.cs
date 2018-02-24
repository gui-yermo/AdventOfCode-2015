using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2015.Puzzle.Day1
{
    class Day1
    {
        private int positionBasement = 0;
        private int floorLevel;
        public Day1(string content)
        {
            for(int i =0; i < content.Length; i++)
            {
                if(content[i] == '(')
                {
                    floorLevel++;
                }
                else if(content[i] == ')')
                {
                    floorLevel--;
                }
                if(positionBasement == 0 && floorLevel == -1)
                {
                    positionBasement = i + 1;
                }
            }
        }
        public int GetFloorLevel()
        {
            return floorLevel;
        }
        public int GetPositionBasement()
        {
            return positionBasement;
        }
    }
}
