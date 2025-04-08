namespace ActivityList.Activity07
{
    internal class Program
    {
        //create a program to identify if the number is a prime number.
        static void Main(string[] args)
        {

                #region input
                Console.WriteLine("Type a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region processing 
                if (number == 0 || number == 1)
                {
                    Console.WriteLine($"The number {number} is not prime.");
                    Console.ReadLine();
                }
                else
                {
                    for (int a = 2; a <= number / 2; a++)
                    {
                      
                        if (number % a == 0)
                        {
                        Console.WriteLine($"The number {number} is not a prime number");
                        Console.ReadLine();
                        return;
                        }
                    }

                    Console.WriteLine($"The number {number} is a prime number");
                    Console.ReadLine();
                #endregion

                }

            


        }
    }
}
