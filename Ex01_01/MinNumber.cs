using System;

namespace Ex01_01
{
    class MinNumber
    {
        public static void printNumbersInsAscending(double i_firstNum, string i_firstStr, double i_secondNum, string i_secondStr, double i_thirdNum, string i_thirdStr)
        {
            double maxDecimal = Math.Max (Math.Max(i_firstNum, i_secondNum),i_thirdNum);
            double minDecimal = Math.Min(Math.Min(i_firstNum, i_secondNum), i_thirdNum);
            string message = "Decimal numbers in ascending order: ";
            if (i_firstNum == minDecimal)
            {
                if (i_thirdNum == maxDecimal)
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    i_firstNum, i_firstStr,i_secondNum, i_secondStr,i_thirdNum, i_thirdStr);
                }
                else
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    i_firstNum, i_firstStr,i_thirdNum, i_thirdStr,i_secondNum, i_secondStr);
                }
            }
            //check if second number is the min decimal
            if (i_secondNum == minDecimal)
            {
                if (maxDecimal == i_thirdNum)
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    i_secondNum, i_secondStr,i_firstNum, i_firstStr,i_thirdNum, i_thirdStr);
                }
                else
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    i_secondNum, i_secondStr,i_thirdNum, i_thirdStr, i_firstNum, i_firstStr);
                }
            }
            //check if third number is the min decimal
            if (i_thirdNum == minDecimal)
            {
                if (i_firstNum < i_secondNum)
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    i_thirdNum, i_thirdStr,i_firstNum, i_firstStr,i_secondNum, i_secondStr);
                }
                else
                {
                    System.Console.WriteLine("{0} {1} ({2}), {3} ({4}), {5} ({6})", message,
                    i_thirdNum, i_thirdStr,i_secondNum, i_secondStr,i_firstNum, i_firstStr);
                }
            }
        }
    }
}
