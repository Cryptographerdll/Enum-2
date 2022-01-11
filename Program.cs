using System;

namespace Enums_Concept
{
    class Program
    {
        //public enum ProductCodes
        //{
        //    Milk = 0, 
        //    Juice = 1, 
        //    Tea = 2 
        //  // Constantes
        //}
        static void Main(string[] args)
        {
            //ProductCodes test = ProductCodes.Milk;
            //Console.WriteLine((int)test); // 0

            //int test2 = 1;
            //Console.WriteLine((ProductCodes)test2); // Juice

            //Console.WriteLine(test.ToString()); // Milk

            //string test3 = "Tea";
            //ProductCodes getParse;

            //bool checkParse = Enum.TryParse(test3, out getParse);
            //Console.WriteLine(getParse); // Tea
            //Console.WriteLine(checkParse); // True

            Console.WriteLine(Planets.Marcury + " is a planet #" + (int)Planets.Marcury);
            Console.WriteLine(Planets.Venus + " is a planet #" + (int)Planets.Venus);


            static double Volum(PlanetRadius radius)
            {
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
                return volume;
            }

            string radius = PlanetRadius.Venus.ToString();

            int rad = (int)PlanetRadius.Venus;

            Double volume = Volum(PlanetRadius.Venus);

            Console.WriteLine("Planet radius is " + rad);
            Console.WriteLine("Planet volum is " + volume);
        }
        enum Planets
        {
            // By default if we dont use integers the system gives 0 as start of indexers
            Venus,
            Earth,
            Jupiter,
            Mars,
            Neptune,
            Saturn,
            Pluto,
            Marcury
        }

        enum PlanetRadius
        {
            Venus = 12231
        }
    }
}
