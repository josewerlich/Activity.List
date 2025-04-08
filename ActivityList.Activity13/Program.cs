namespace ActivityList.Activity13
{
    internal class Program
    {
        //create a program to read a number and print the factorial calculation
        static void Main(string[] args)
        {
            int number, factorial = 1;

            Console.Write("Type a number: ");

            number = Convert.ToInt32(Console.ReadLine());

            Console.Write(number + "! = ");

            for (int counter = number; counter >= 1; counter--)

            {

                Console.Write(counter + " ");

                factorial *=  counter;

                if (counter > 1)

                {

                    Console.Write("*");

                }

            }

            Console.Write("= " + factorial);

            Console.ReadLine();
        }
    }
}
