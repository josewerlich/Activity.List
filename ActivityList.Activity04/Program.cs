namespace ActivityList.Activity04
{
    internal class Program
    {
        //create a program to conver Celsius to Fahrenheit
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Type the temperature in Celsius:");
            decimal celcius = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processing 
            decimal result = (celcius * 9 / 5) + 32;
            #endregion

            #region output
            Console.WriteLine($"The temperature in Fahrenheit: {result}");
            Console.ReadLine();
            #endregion
        }
    }
}
