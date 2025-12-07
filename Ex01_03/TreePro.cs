using System.Text;

namespace Ex01_03
{
    class TreePro
    {
        private static bool heightCheck(string height)
        {
            int heightInt = int.Parse(height);
            if (heightInt <= 15 && heightInt >= 4)
            {
                return true;
            }
            return false;
        }
        private static string spaces(int num)
        {
            string space = " ";
            for (int j = 0; j < num; j++)
            {
                space += " ";
            }
            return space;
        }
        public static void TreeProCreation()
        {
            //get height and check if valid
            System.Console.WriteLine("Hi, please enter the tree height you want (anywhere between 4 and 15):");
            string treeHeight = System.Console.ReadLine();
            while (heightCheck(treeHeight) == false)
            {
                System.Console.WriteLine("Error - please enter valid number between 4  and 15");
                treeHeight = System.Console.ReadLine();
            }
            int currentNum = 1;
            int treeHeightInt = (int.Parse(treeHeight)) - 2;
            char rowLetter = 'A';
            for (int i = 0; i < treeHeightInt; i++)
            {
                int numOfSpaces = (treeHeightInt - i - 1) * 2;
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
            int trunkLocation = (treeHeightInt - 1) * 2 - 1;
            for (int t = 0; t < 2; t++)
            {
                string res = spaces(trunkLocation); ;
                System.Console.WriteLine("{0}{1}|{2}|", rowLetter, res, currentNum);
                rowLetter++;
            }
        }
    }
}
           
