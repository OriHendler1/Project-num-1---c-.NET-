using System;
using System.Runtime.Remoting.Messaging;

namespace Ex01_01
{
    class BitSequence
    {
        private static int squenceCounter(string s)
        {
            int binaryInt = int.Parse(s);
            int binaryCounter = 1;
            int x = binaryInt % 10;
            binaryInt /= 10;
            while (binaryInt > 0)
            {
                if (x == binaryInt % 10)
                {
                    binaryCounter++;
                    x = binaryInt % 10;
                    binaryInt /= 10;
                }
                else
                {
                    x = binaryInt % 10;
                    binaryInt /= 10;
                    binaryCounter = 1;
                }
            }
            return binaryCounter;
        }       
        public static void ShortestBitSequence(string binary1, string binary2, string binary3)
        {
            //check bit squence
            int binary1Counter = BitSequence.squenceCounter(binary1);
            int binary2Counter = BitSequence.squenceCounter(binary2);
            int binary3Counter = BitSequence.squenceCounter(binary3);
            int minCounterValue = Math.Min(Math.Min(binary1Counter, binary2Counter), binary3Counter);
            string message = "Shortest bit sequence:";
            if (binary1Counter == binary2Counter && binary1Counter == binary3Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3},{4})",message , minCounterValue, binary1, binary2, binary3);
                return;
            }
            if (binary1Counter == binary2Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3})", message, minCounterValue, binary1, binary2);
                return;
            }
            if (binary1Counter == binary3Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3})", message, minCounterValue, binary1, binary3);
                return;
            }
            if (binary2Counter == binary3Counter)
            {
                System.Console.WriteLine("{0} {1}, ({2},{3})", message, minCounterValue, binary2, binary3);
                return;
            }
            if (binary1Counter == minCounterValue)
            {
                System.Console.WriteLine("{0} {1}, ({2})", message, minCounterValue, binary1);
                return;
            }
            if (binary2Counter == minCounterValue)
            {
                System.Console.WriteLine("{0} {1}, ({2})", message, minCounterValue, binary2);
                return;
            }
            else
            {
                System.Console.WriteLine("{0} {1}, ({2})", message, minCounterValue, binary3);
                return;
            }
        }
        
    }
}
