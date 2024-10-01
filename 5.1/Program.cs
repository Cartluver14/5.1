namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int rightnumber;

            rightnumber = 7;

            Console.WriteLine("guess a number from 1 to 10 to win!");
            int.TryParse(Console.ReadLine(), out number);

            if (number == 7)
            {

                Console.WriteLine("Congrats you won!");







            }
            else
            {
                Console.WriteLine("Your wrong its acutully " +  rightnumber);


            }
               
        }
    }
}
