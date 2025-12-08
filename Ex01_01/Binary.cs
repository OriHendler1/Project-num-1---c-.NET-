using System;
using System.Globalization;
using System.IO;


namespace Ex01_01
{
    class Binary
    {
        private static bool binaryStartAndEndSameChar(string i_binaryStr)
        {
            return i_binaryStr[0] == i_binaryStr[i_binaryStr.Length - 1];
        }
        public static bool IsBinary(string i_strInput)
        {
            bool isValid = true;
            foreach (char c in i_strInput)
            { 
                if (c != '0' && c != '1')
                {
                return !isValid;
                }
            }
        return isValid;
        }
        public static double BinaryToDecimal(int i_binaryNum)
        {
            double decimalNumber = 0;
            int i = 0;
            while(i_binaryNum > 0) 
            {
                int tempNumber = i_binaryNum % 10;
                i_binaryNum /= 10;
                decimalNumber += tempNumber * Math.Pow(2, i);
                i++;
            }
            return decimalNumber;
        }
        public static void BinaryStartAndEndSameCharCount(string i_binary1, string i_binary2, string i_binary3)
        {
            string binaryExample = "";
            int counter = 0;           
            if (binaryStartAndEndSameChar(i_binary1))
            {
                binaryExample += i_binary1;
                counter++;
            }
            if (binaryStartAndEndSameChar(i_binary2))
            {
                binaryExample += ", " + i_binary2;
                counter++;
            }
            if (binaryStartAndEndSameChar(i_binary3))
            {
                binaryExample += ", " + i_binary3;
                counter++;
            }
            string message = string.Format("Numbers that start and end with same digit: {0} ({1})", counter, binaryExample);
            System.Console.WriteLine(message);
        }
    }
}
