namespace Ex01_01
{
    class Palindrome
    {
        private static bool isBinaryPalindrome(string i_binaryNum)
        {
            if (i_binaryNum[0] == i_binaryNum[7] && i_binaryNum[1] == i_binaryNum[6] && 
                i_binaryNum[2] == i_binaryNum[5] && i_binaryNum[3] == i_binaryNum[4])
            { 
                return true;
            }
            else
            {
                return false;
            }   
        }
        public static void FindPalindrome(string i_binary1, string i_binary2, string i_binary3)
        {
            string palindromeExample = "There is no Palindrome";
            int palindromeCount = 0;
            if (isBinaryPalindrome(i_binary1))
            { 
                palindromeCount++;
                palindromeExample = i_binary1;
            }
            if (isBinaryPalindrome(i))
            {
                palindromeCount++;
                palindromeExample = i_binary2;
            }
            if (isBinaryPalindrome(i_binary3))
            {
                palindromeCount++;
                palindromeExample = i_binary3;
            }
        System.Console.WriteLine("Number of palindromes:{0} ({1})", palindromeCount, palindromeExample);
        }
    }
}
