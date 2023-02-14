using System;

namespace _2023_MED2_Ch10_AdditionalExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int outsideVar = 20;
                SomeFunction(outsideVar);
                Console.WriteLine(outsideVar);
            }
        }

        static void SomeFunction( int insideVar)
        {
            insideVar = insideVar + 10;
        }
    }
}
