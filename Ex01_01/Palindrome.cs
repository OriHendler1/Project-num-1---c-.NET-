namespace Ex01_01
{
    class Palindrome
    {
        private static bool isBinaryPalindrome(string binaryNum)
        {
            if (binaryNum[0] == binaryNum[7] && binaryNum[1] == binaryNum[6] && 
                binaryNum[2] == binaryNum[5] && binaryNum[3] == binaryNum[4])
            { 
                return true;
            }
            else
            {
                return false;
            }   
        }
        public static void FindPalindrome(string binary1, string binary2, string binary3)
        {
            string palindromeExample = "There is no Palindrome";
            int palindromeCount = 0;
            if (isBinaryPalindrome(binary1))
            { 
                palindromeCount++;
                palindromeExample = binary1;
            }
            if (isBinaryPalindrome(binary2))
            {
                palindromeCount++;
                palindromeExample = binary2;
            }
            if (isBinaryPalindrome(binary3))
            {
                palindromeCount++;
                palindromeExample = binary3;
            }
        System.Console.WriteLine("Number of palindromes:{0} ({1})", palindromeCount, palindromeExample);
        }
    }
}
