namespace Ex01_05
{
    class GetNumber
    {
        public static string GetNewNumber()
        {
            System.Console.WriteLine("Hi, please enter 7-character number (and press enter):");
            string NumberStr = System.Console.ReadLine();
            bool isNumberValid = false;
            while (isNumberValid == false)
                if (NumberStr.Length == 7 && (int.TryParse(NumberStr, out int o_number)))
                {
                    isNumberValid = true;
                }
                else
                {
                    System.Console.WriteLine("Binary number is Invalid");
                    isNumberValid = false;
                    System.Console.WriteLine("Hi, please enter 7-character number (and press enter):");
                    NumberStr = System.Console.ReadLine();
                }
            return NumberStr;
        }
    }
}
