using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Ex01_04
{
    class CheckString
    {
        private static bool isPalindrome(StringBuilder i_input, int i_start, int i_end)
        {
            if (i_start >= i_end)
            {
                return true;
            }
            if (i_input[i_start] != i_input[i_end])
            {
                return false;
            }
            return isPalindrome(i_input, i_start + 1, i_end - 1);
        }
        private static bool ifStringAllNumber(string i_input)
        {
            if (long.TryParse(i_input, out long i_number))
            {
                return true;
            }
                return false;
        }
        private static void checkIfStringDivideBy3(string i_input)
        {
            if (ifStringAllNumber(i_input) == true)
            { 
                if (int.Parse(i_input) % 3 == 0)
                {
                    System.Console.WriteLine("Is divisible by 3?: YES");
                }
            }
        }
        private static bool ifStringAllLetters(string i_input)
        {
            foreach (char i_c in i_input)
            {
                if (char.IsLetter(i_c) == false)
                { 
                    return false;
                }
            }
            return true;
        }
        private static int numOfLowercase(string i_input)
        {
            int counter = 0;
            if (ifStringAllLetters(i_input) == true)
            {
                foreach (char i_c in i_input)
                {
                    if (i_c >= 'a' && i_c <= 'z')
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        private static bool ascendingAlphbeticalOrder(string i_input)
        {
            if (ifStringAllLetters(i_input) == true)
            {
                i_input = i_input.ToLower();
                for (int i = 0;  i < i_input.Length - 1 ; i++)
                {
                    if (i_input[i] >= i_input[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static void CheckStringAnalysis(string i_userInput) //change the name
        {
            //check if string is palindorme
            StringBuilder userInputSb = new StringBuilder(i_userInput);
            bool isPalindormeResult = isPalindrome(userInputSb, 0, i_userInput.Length - 1);
            System.Console.WriteLine("Is Palindorme: {0}", isPalindormeResult);
            //if divided by 3
            checkIfStringDivideBy3(i_userInput);
            if (ifStringAllNumber(i_userInput) == false)
            { 
                //number of Lowercase
                System.Console.WriteLine("Number of Lowercase: {0}", numOfLowercase(i_userInput));
                //ascending alphbetical order
                System.Console.WriteLine("Is in ascending alphbetical order: {0}", ascendingAlphbeticalOrder(i_userInput));
            }
        }

    }
}
