namespace Ex01_04
{
    class NewString
    {
        public static string GetNewString() 
        {
            System.Console.WriteLine("Hi, please enter 10 character string (and press enter):");
            string newString = System.Console.ReadLine();
            bool isStrValid = false;
            while (isStrValid == false)
                if (newString.Length == 10)
                {
                    isStrValid = true;
                }
                else
                {
                    isStrValid = false;
                    System.Console.WriteLine("Hi, please enter 10 character string (and press enter):");
                    newString = System.Console.ReadLine();
                }
            return newString;
            ;
        }
    }
}
