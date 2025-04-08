namespace ActivityList.Activity11
{
    internal class Program
    {
        //create a program to inform if a number is even or odd
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number: ");
            decimal N = Convert.ToDecimal(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            Console.ReadLine();
        }
    }
}
