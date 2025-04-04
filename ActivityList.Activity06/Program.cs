namespace ActivityList.Activity06
{
    internal class Program
    {
        //create a program to calculate the weighted average for two test
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Type the first test result: ");
            decimal firstTest = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type the first test weight:");
            decimal firstTestWeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type the second test result: ");
            decimal secondTest = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type the second test weight:");
            decimal secondTestWeight = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processing 
            decimal result = (firstTest * firstTestWeight+secondTest * secondTestWeight)/(firstTestWeight + secondTestWeight);
            #endregion

            #region output
            Console.WriteLine($"The GPA is: {result}");
            Console.ReadLine();
            #endregion
        }
    }
}
