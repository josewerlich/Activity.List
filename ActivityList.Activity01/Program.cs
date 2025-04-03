namespace ActivityList.Activity01
{
    internal class Program
    {

        //Create a program to calculate the volume of a rectangular box

        static void Main(string[] args)
        {


            #region input
            Console.WriteLine("Type the lenght of the box:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type the width of the box:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type the height of the box:");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processing 
            decimal result = length * width * height;
            #endregion

            #region output
            Console.WriteLine($"The volume of the box is: {result}");
            Console.ReadLine();
            #endregion
        }
    }
}
