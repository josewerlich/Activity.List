namespace ActivityList.Activity15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                if (counter % 3 == 0 && counter % 5 == 0)

                {
                    Console.Write("FizzBuzz ");
                }
                else if (counter % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (counter % 5 == 0)

                {
                    Console.Write("Buzz ");
                }

                else
                {
                    Console.Write(Convert.ToString(counter) + " ");
                }
            
            }
            Console.ReadLine();
        }

    }
}
