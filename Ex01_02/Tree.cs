using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_02
{
    class Tree
    {
        private static string spaces(int i_num)
        {
            string space = " ";
            for (int j = 0; j < i_num; j++)
            {
                space += " ";
            }
            return space;
        }
        public static void TreeCreation() 
        {
            int currentNum = 1;
            int height = 5;
            char rowLetter = 'A';
            //create the rows
            for (int i = 0; i < height; i++)
            { 
                int numOfSpaces = (height - i - 1)*2;
                int numInRow = i * 2 + 1;
                var currentRow = new StringBuilder();
                for (int j = 0; j < numInRow; j++)
                {
                    currentRow.Append(currentNum);
                    currentRow.Append(" ");
                    currentNum++;
                    if (currentNum == 10)
                    {
                        currentNum = 1;
                    }
                }
                string res = spaces(numOfSpaces);
                System.Console.WriteLine(rowLetter + res + currentRow);
                rowLetter++;
            }
            //create the trunk
            int trunkLocation = (height - 1)*2-1;
            for (int t = 0; t < 2; t++)
            {
                string res = spaces(trunkLocation); ;
                System.Console.WriteLine("{0}{1}|{2}|",rowLetter ,res, currentNum);
                rowLetter++;
            }       
        }
    }
}
