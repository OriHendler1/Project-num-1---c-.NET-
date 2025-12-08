using System;
using System.Runtime.Remoting.Messaging;

namespace Ex01_01
{
    class BitSequence
    {
        private static int squenceCounter(string i_binaryStr)
        {
            int binaryInt = int.Parse(i_binaryStr);
            int binaryCounter = 1;
            int currentBinary = binaryInt % 10;
            binaryInt /= 10;
            while (binaryInt > 0)
            {
                if (currentBinary == binaryInt % 10)
                {
                    binaryCounter++;
                    currentBinary = binaryInt % 10;
                    binaryInt /= 10;
                }
                else
                {
                    currentBinary = binaryInt % 10;
                    binaryInt /= 10;
                    binaryCounter = 1;
                }
            }
            return binaryCounter;
        }       
        public static void ShortestBitSequence(string i_binary1, string i_binary2, string i_binary3)
        {
            //check bit squence
            int binary1Counter = BitSequence.squenceCounter(i_binary1);
            int binary2Counter = BitSequence.squenceCounter(i_binary2);
            int binary3Counter = BitSequence.squenceCounter(i_binary3);
            int minCounterValue = Math.Min(Math.Min(binary1Counter, binary2Counter), binary3Counter);
            string message = "Shortest bit sequence:";
            if (binary1Counter == binary2Counter && binary1Counter == binary3Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3},{4})",message , minCounterValue, i_binary1, i_binary2, i_binary3);
                return;
            }
            if (binary1Counter == binary2Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3})", message, minCounterValue, i_binary1, i_binary2);
                return;
            }
            if (binary1Counter == binary3Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3})", message, minCounterValue, i_binary1, i_binary3);
                return;
            }
            if (binary2Counter == binary3Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3})", message, minCounterValue, i_binary2, i_binary3);
                return;
            }
            if (binary1Counter == minCounterValue)
            {
                System.Console.WriteLine("{0} {1}, ({2})", message, minCounterValue, i_binary1);
                return;
            }
            if (binary2Counter == minCounterValue)
            {
                System.Console.WriteLine("{0} {1}, ({2})", message, minCounterValue, i_binary2);
                return;
            }
            else
            {
                System.Console.WriteLine("{0} {1}, ({2})", message, minCounterValue, i_binary3);
                return;
            }
        }
        
    }
}
