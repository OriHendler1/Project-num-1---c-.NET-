using System;
using System.Globalization;
using System.IO;


namespace Ex01_01
{
    class Binary
    {
        private static bool binaryStartAndEndSameChar(string binaryNum)
        {
            return binaryNum[0] == binaryNum[binaryNum.Length - 1];
        }
        public static bool IsBinary(string s)
        {
            foreach (char c in s)
            { 
                if (c != '0' && c != '1')
                {
                return false;
                }
            }
        return true;
        }
        public static double BinarytoDecimal(int x)
        {
            double decimalNumber = 0;
            int i = 0;
            while(x > 0) 
            {
                int tempNumber = x % 10;
                x /= 10;
                decimalNumber += tempNumber * Math.Pow(2, i);
                i++;
            }
            return decimalNumber;
        }
        public static void BinaryStartAndEndSameCharCount(string binary1, string binary2, string binary3)
        {
            string binaryExample = "";
            int counter = 0;           
            if (binaryStartAndEndSameChar(binary1))
            {
                binaryExample += binary1;
                counter++;
            }
            if (binaryStartAndEndSameChar(binary2))
            {
                binaryExample += ", " + binary2;
                counter++;
            }
            if (binaryStartAndEndSameChar(binary3))
            {
                binaryExample += ", " + binary3;
                counter++;
            }
            string message = string.Format("Numbers that start and end with same digit:{0} ({1})", counter, binaryExample);
            System.Console.WriteLine(message);
        }
    }
}
