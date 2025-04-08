namespace ActivityList.Activity14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a program to show the Fibonacci calc of a number
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
}
