using System;

namespace Ex01_01
{
    internal class MaxDifference
    {
        private static int maxDefferenceCounter(string i_binaryStr)
        {
            int numOfones = 0;
            int numOfzeros = 0;
            foreach (char c in i_binaryStr)
            {
                if (c == '1')
                {
                    numOfones++;
                }
                else
                {
                    numOfzeros++;
                }
            }
            return Math.Max(numOfones, numOfzeros);
        }
        public static void LongestBitSequence(string i_binary1, string i_binary2, string i_binary3)
        {
            //check bit squence
            int binary1Counter = maxDefferenceCounter(i_binary1);
            int binary2Counter = maxDefferenceCounter(i_binary2);
            int binary3Counter = maxDefferenceCounter(i_binary3);
            int maxCounterValue = Math.Max(Math.Max(binary1Counter, binary2Counter), binary3Counter);
            string message = "Number with maximum difference between 1s and 0s:";
            if (binary1Counter == binary2Counter && binary1Counter == maxCounterValue)
            {
                double decimalNum1 = Binary.BinaryToDecimal(int.Parse(i_binary1));
                double decimalNum2 = Binary.BinaryToDecimal(int.Parse(i_binary2));
                double maxDecimalNumber = Math.Max(decimalNum1, decimalNum2);
                if (decimalNum1 == maxDecimalNumber)
                {
                    string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, maxDecimalNumber, i_binary1, binary1Counter);
                    System.Console.WriteLine(newMessage);
                    return;
                }
                else
                {
                    string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, maxDecimalNumber, i_binary2, binary1Counter);
                    System.Console.WriteLine(newMessage);
                    return;
                }
            }
            if (binary3Counter == binary2Counter && binary3Counter == maxCounterValue)
            {
                double decimalNum3 = Binary.BinaryToDecimal(int.Parse(i_binary3));
                double decimalNum2 = Binary.BinaryToDecimal(int.Parse(i_binary2));
                double maxDecimalNumber = Math.Max(decimalNum3, decimalNum2);
                if (decimalNum3 == maxDecimalNumber)
                {
                    string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, maxDecimalNumber, i_binary3, binary1Counter);

                }
                else
                {
                    string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, maxDecimalNumber, i_binary2, binary1Counter);
                    System.Console.WriteLine(newMessage);
                    return;
                }
            }
            if (binary3Counter == binary1Counter && binary1Counter == maxCounterValue)
            {
                double decimalNum3 = Binary.BinaryToDecimal(int.Parse(i_binary3));
                double decimalNum1 = Binary.BinaryToDecimal(int.Parse(i_binary1));
                double maxDecimalNumber = Math.Max(decimalNum3, decimalNum1);
                if (decimalNum3 == maxDecimalNumber)
                {
                    string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, maxDecimalNumber, i_binary3, binary1Counter);
                    System.Console.WriteLine(newMessage);
                    return;
                }
                else
                {
                    string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, maxDecimalNumber, i_binary1, binary1Counter);
                    System.Console.WriteLine(newMessage);
                    return;
                }
            }
            if (maxCounterValue == binary1Counter)
            {
                double decimalNum = Binary.BinaryToDecimal(int.Parse(i_binary1));
                string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, decimalNum, i_binary1, binary1Counter);
                System.Console.WriteLine(newMessage);
                return;
            }
            if (maxCounterValue == binary2Counter)
            {
                double decimalNum = Binary.BinaryToDecimal(int.Parse(i_binary2));
                string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, decimalNum, i_binary2, binary1Counter);
                System.Console.WriteLine(newMessage);
                return;
            }
            else
            {
                double decimalNum = Binary.BinaryToDecimal(int.Parse(i_binary3));
                string newMessage = string.Format("{0} {1} ({2}) - difference of: {3}", message, decimalNum, i_binary3, binary1Counter);
                System.Console.WriteLine(newMessage);
                return;
            }


        }
    }
}
