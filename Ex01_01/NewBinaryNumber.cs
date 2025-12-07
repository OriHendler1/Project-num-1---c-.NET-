namespace Ex01_01
{
    class NewBinaryNumber
    {
        public static string BinaryNumber()
        {
            System.Console.WriteLine("Hi, please enter first 8-character binary number (and press enter):");
            string NumberStr = System.Console.ReadLine();
            bool isNumberValid = false;
            while (isNumberValid == false)
                if (NumberStr.Length == 8 && Binary.IsBinary(NumberStr))
                {
                    isNumberValid = true;
                }
                else
                {
                    System.Console.WriteLine("Binary number is Invalid");
                    isNumberValid = false;
                    System.Console.WriteLine("Hi, please enter first 8-character binary number (and press enter):");
                    NumberStr = System.Console.ReadLine();
                }
            return NumberStr;
        }
    }
}
