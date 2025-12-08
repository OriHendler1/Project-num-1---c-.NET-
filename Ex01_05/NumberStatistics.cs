using System;

namespace Ex01_05
{
    class NumberStatistics
    {
        private static void largerNumberCount(int i_number)
        {
            int leftNumber = i_number / 1000000;
            int counter = 0;
            for (int j = 0; j < 6; j++)
            {
                int x = i_number % 10;
                i_number /= 10;
                if (leftNumber < x)
                {
                    counter++;
                }
            }
            System.Console.WriteLine("left Number:{0}. greater digits (without the left one): {1}", leftNumber, counter);
        }
        private static void divideBy3(int i_number)
        {
            int counter = 0;
            for (int i = 0; i < 7; i++)
            {
                int x = i_number % 10;
                i_number /= 10;
                if (x % 3 == 0)
                {
                    counter++;
                }
            }
            System.Console.WriteLine("The amount of numbers that are divided by 3:{0}", counter);
        }
        private static void largestAndSmallestDigitDiff(int i_number)
        {
            int minNumber = 9;
            int maxNumber = 0;
            for (int i = 0; i < 7; i++)
            {
                int x = i_number % 10;
                i_number /= 10;
                minNumber = Math.Min(minNumber, x);
                maxNumber = Math.Max(maxNumber, x);
            }
            System.Console.WriteLine("The difference between the smallest and lagest digits:{0}", maxNumber - minNumber);
        }
        private static void frequentDigit(string i_numberStr)
        {
            int mostFrequentDigit = 0;
            int maxCount = 0;
            for (char i = '0'; i < '9'; i++)
            {
                int counter = 0;
                foreach (char c in i_numberStr)
                {
                    if (c == i)
                    {
                        counter++;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    mostFrequentDigit = i - '0';
                }
            }
            System.Console.WriteLine("The frequent digit is:{0} (appers {1} times)", mostFrequentDigit, maxCount);
        }
        public static void CheckNumberStatistics(string i_userInputStr)
        {
            int i_userInputInt = int.Parse(i_userInputStr);
            largerNumberCount(i_userInputInt);
            divideBy3(i_userInputInt);
            largestAndSmallestDigitDiff(i_userInputInt);
            frequentDigit(i_userInputStr);
        }
    }
}


