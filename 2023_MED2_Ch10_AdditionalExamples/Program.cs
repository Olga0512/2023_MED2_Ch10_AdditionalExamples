using System;

namespace _2023_MED2_Ch10_AdditionalExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            {
             //   int outsideVar = 20;
                SomeFunction(out outsideVar);
                Console.WriteLine(outsideVar);
            }
        }

        static void SomeFunction( out int insideVar)
        {
            insideVar = 15;
            insideVar = insideVar + 10;
        }
    }
}
