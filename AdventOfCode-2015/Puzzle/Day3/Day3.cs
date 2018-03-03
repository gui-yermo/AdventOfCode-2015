using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2015.Puzzle.Day3
{
    class Day3
    { 

        private List<Position> listHouse;
        private List<Position> listSanta;
        private List<Position> listRoboSanta;
        private int x, y;
        private int xSanta, ySanta;
        private int xRoboSanta, yRoboSanta;
        public Day3(string content)
        {
            listHouse = new List<Position>();
            listSanta = new List<Position>();
            Position p;
            p.x = x;
            p.y = y;
            listHouse.Add(p);
            listSanta.Add(p);
            x = 0;
            y = 0;
            xSanta = 0;
            ySanta = 0;
            xRoboSanta = 0;
            yRoboSanta = 0;
            for (int i = 0; i < content.Length; i++)
            {   
                if(i%2 == 0)
                {
                    p = GetPosition(content[i],ref xSanta,ref ySanta);
                    
                }
                else
                {
                    p = GetPosition(content[i],ref xRoboSanta,ref yRoboSanta);
                    
                }
               
                if (!listSanta.Contains(p))
                {
                    listSanta.Add(p);
                }
                p = GetPosition(content[i], ref x, ref y);
                if (!listHouse.Contains(p))
                {
                    listHouse.Add(p);
                }
            }
        }
        public Position GetPosition(char value,ref int x,ref int y)
        {
            if (value == '^')
            {
                y++;
            }
            else if (value == 'v')
            {
                y--;
            }
            else if (value == '>')
            {
                x++;
            }
            else if (value == '<')
            {
                x--;
            }
            Position t;
            t.x = x;
            t.y = y;
            return t;
        }
        public int GetHousePresent()
        {
            return this.listHouse.Count;
        }
        public int GetHouseSanta()
        {
            return this.listSanta.Count;
        }
    }
  
}
