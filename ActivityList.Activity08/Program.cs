namespace ActivityList.Activity08
{
    internal class Program
    {
        //Create a program to read A,B and C values and print if the sum of A+B is lower than C.
        static void Main(string[] args)
        {
            int totalValue = 0;
            #region input
            Console.WriteLine("Type the value A: ");
            int valueA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the value B: ");
            int valueB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the value C: ");
            int valueC= Convert.ToInt32(Console.ReadLine());

            #endregion

            #region processing 
            totalValue = valueA + valueB;
            if (totalValue < valueC)
            {
                Console.WriteLine("The sum of A + B is lower than C");
            }
            else
                Console.WriteLine("The sum of A + B is higher than C");

                #endregion

                #region output
            Console.ReadLine();
            #endregion
        }
    }
}
