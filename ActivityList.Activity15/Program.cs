namespace ActivityList.Activity15
{
    internal class Program
    {
        //create a program to print numbers from 1 to 100 replacing the numbers multiples of 3 for the word "Fizz", mupliples of 5 to "Buzz" and numbers that are mutiples of both, 3 and 5 the word "FizzBuzz".
        
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
