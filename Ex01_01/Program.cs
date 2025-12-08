using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Ex01_01
{
    class Program
    {
        public static void Main()
        {
            //get binary number
            string firstNumberStr = NewBinaryNumber.BinaryNumber();
            string secondNumberStr = NewBinaryNumber.BinaryNumber();
            string thirdNumberStr = NewBinaryNumber.BinaryNumber();
            //parse binary input from string to int
            int firstNumberInt = int.Parse(firstNumberStr);
            int secondNumberInt = int.Parse(secondNumberStr);
            int thirdNumberInt = int.Parse(thirdNumberStr);
            //convert binary number to decimal
            double firstNumberDecimal = Binary.BinaryToDecimal(firstNumberInt);
            double secondNumberDecimal = Binary.BinaryToDecimal(secondNumberInt);
            double thirdNumberDecimal = Binary.BinaryToDecimal(thirdNumberInt);
            //check if first number is the min decimal
            MinNumber.printNumbersInsAscending(firstNumberDecimal, firstNumberStr,secondNumberDecimal, secondNumberStr, thirdNumberDecimal, thirdNumberStr);
            //check avg (1.1)
            double sumOfDecimalNumbers = firstNumberDecimal + secondNumberDecimal + thirdNumberDecimal;
            double avgDecimalNumber = sumOfDecimalNumbers / 3;
            System.Console.WriteLine("Average:" + avgDecimalNumber);
            //shortest bit sequence (1.2)
            BitSequence.ShortestBitSequence(firstNumberStr, secondNumberStr, thirdNumberStr);
            //find palindrome (1.3)
            Palindrome.FindPalindrome(firstNumberStr, secondNumberStr, thirdNumberStr);
            //Longest bit sequence (1.4)
            MaxDifference.LongestBitSequence(firstNumberStr, secondNumberStr, thirdNumberStr);
            //same first and last char (1.5)
            Binary.BinaryStartAndEndSameCharCount(firstNumberStr, secondNumberStr, thirdNumberStr);
        }
    }
}