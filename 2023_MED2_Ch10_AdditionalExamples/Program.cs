using System;

namespace _2023_MED2_Ch10_AdditionalExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             benefits = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
            int n = fish.NumOfLegs();
            Console.WriteLine(n);

            Console.ReadKey();
        }
        interface IPrey
        {
            void Flee();
      
   

        }
        interface IPredator
        {
            void Hunt();
            int NumOfLegs();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
            private int numOfLegs = 2;
            public int NumOfLegs()
            {
                return numOfLegs;

            }

        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }

            private int numOfLegs = 17;
            public int NumOfLegs()
            {
                return numOfLegs;

            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        }
    }
}
