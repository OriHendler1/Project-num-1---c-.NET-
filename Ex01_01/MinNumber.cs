using System;

namespace Ex01_01
{
    class MinNumber
    {
        public static void printNumbersInsAscending(double firstNum, string firstStr, double secondNum, string secondStr, double thirdNum, string thirdStr)
        {
            double maxDecimal = Math.Max (Math.Max(firstNum, secondNum),thirdNum);
            double minDecimal = Math.Min(Math.Min(firstNum, secondNum), thirdNum);
            string message = "Decimal numbers in ascending order: ";
            if (firstNum == minDecimal)
            {
                if (thirdNum == maxDecimal)
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    firstNum, firstStr,secondNum, secondStr,thirdNum, thirdStr);
                }
                else
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    firstNum, firstStr,thirdNum, thirdStr,secondNum, secondStr);
                }
            }
            //check if second number is the min decimal
            if (secondNum == minDecimal)
            {
                if (maxDecimal == thirdNum)
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    secondNum, secondStr,firstNum, firstStr,thirdNum, thirdStr);
                }
                else
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    secondNum, secondStr,thirdNum, thirdStr, firstNum, firstStr);
                }
            }
            //check if third number is the min decimal
            if (thirdNum == minDecimal)
            {
                if (firstNum < secondNum)
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    thirdNum, thirdStr,firstNum, firstStr,secondNum, secondStr);
                }
                else
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    thirdNum, thirdStr,secondNum, secondStr,firstNum, firstStr);
                }
            }
        }
    }
}
