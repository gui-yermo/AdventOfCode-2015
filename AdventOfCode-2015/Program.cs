using AdventOfCode2015.FileReader;
using AdventOfCode2015.Puzzle.Day1;
using AdventOfCode2015.Puzzle.Day2;
using AdventOfCode2015.Puzzle.Day3;
using System;

namespace AdventOfCode2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = -1;
            while(dayNumber != 0)
            {
                Console.WriteLine("Enter the day you want to see");
                if (int.TryParse(Console.ReadLine(), out dayNumber))
                {
                    switch (dayNumber)
                    {
                        case 1:
                            string content = new ReadFile(dayNumber).GetFileContent();
                            Day1 instance = new Day1(content);
                            Console.WriteLine(" floor at the end " + instance.GetFloorLevel());
                            Console.WriteLine("position first time basement " + instance.GetPositionBasement());
                            break;
                        case 2:
                            content = new ReadFile(dayNumber).GetFileContent();
                            Console.WriteLine("Total of square foot of wrap paper required " + new Day2(content).GetTotalWrapPaper());
                            Console.WriteLine("Total size of ribbon required " + new Day2(content).GetRibbonSize());
                            break;
                        case 3:
                            content = new ReadFile(dayNumber).GetFileContent();
                            Day3 day = new Day3(content);
                            Console.WriteLine("number of house with one santa : " + day.GetHousePresent());
                            Console.WriteLine("number of house with two santa : " + day.GetHouseSanta()); 
                            break;
                    }
                }
                else
                {
                    //user gave an illegal input. Handle it here.
                }
            }
           
        }
    }
}
