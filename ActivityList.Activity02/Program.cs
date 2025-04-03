namespace ActivityList.Activity02
{
    internal class Program
    {
        //create a program to calculate a cilinder 
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Type the radius of the cilinder:");
            double radius = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Type the height of the cilinder:");
            double height = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processing 
            double result = Math.PI * Math.Pow(radius, 2) * height;
            #endregion

            #region output
            Console.WriteLine($"The volume of the cilinder is: {result}");
            Console.ReadLine();
            #endregion
        }
    }
}
