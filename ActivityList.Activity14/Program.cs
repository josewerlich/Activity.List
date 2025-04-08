namespace ActivityList.Activity14
{
    internal class Program
    {

        //create a program to read a number and show the Fibonacci sequency
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int fibonacci1 = 0, fibonacci2 = 1;

            Console.Write(fibonacci1 + " " + fibonacci2 + " ");

            while (fibonacci2 < number)

            {

                int fibonacci3 = fibonacci1 + fibonacci2;

                Console.Write(fibonacci3 + " ");

                fibonacci1 = fibonacci2;

                fibonacci2 = fibonacci3;

            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
