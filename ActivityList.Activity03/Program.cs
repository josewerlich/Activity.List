namespace ActivityList.Activity03
{
    internal class Program
    {
        //create a program to calcule the gas consumption of a car
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Type the initial odometer reading :");
            decimal initialOdometer = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type the final odometer reading :");
            decimal finalOdometer = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type the gas used in liters:");
            decimal gasUsed = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region processing 
            decimal result = (finalOdometer - initialOdometer) / gasUsed;
            #endregion

            #region output
            Console.WriteLine($"The consumption was {result} liters");
            Console.ReadLine();
            #endregion
        }
    }
}
