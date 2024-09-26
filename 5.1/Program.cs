namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double earthweight;
            int planet;

            Console.WriteLine("What planet would you like me to fight on");
            Console.WriteLine("1. Venus 2. Mars 3. Jupiter 4. Saturn 5. Uranus 6. Neptune");
            planet = int.Parse(Console.ReadLine());
            Console.WriteLine(" What is your weight on earth?");
            earthweight = double.Parse(Console.ReadLine());

            if (planet == 1)
            {
                Console.WriteLine(" on venus your weight would be " + earthweight * 0.78 + "Lbs");
                Console.WriteLine(" get that dub sigma");

            }

            if (planet == 2)
            {
                Console.WriteLine(" on mars your weight would be " + earthweight * 0.39 + "Lbs");
                Console.WriteLine(" get that dub sigma");


            }

            if (planet == 3)
            {
                Console.WriteLine(" on jupiter your weight would be " + earthweight * 2.65 + "Lbs");
                Console.WriteLine(" get that dub sigma");


            }

            if (planet == 4)
            {
                Console.WriteLine(" on saturn your weight would be " + earthweight * 1.17 + "Lbs");
                Console.WriteLine(" get that dub sigma");


            }

            if (planet == 5)
            {
                Console.WriteLine(" on urainus your weight would be " + earthweight * 1.05 + "Lbs");
                Console.WriteLine(" get that dub sigma");



            }

            if (planet == 6)
            {
                Console.WriteLine(" on venus your weight would be " + earthweight * 1.23 + "Lbs");
                Console.WriteLine(" get that dub sigma");


            }
        } } }

