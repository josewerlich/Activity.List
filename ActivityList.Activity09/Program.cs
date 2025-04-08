namespace ActivityList.Activity09
{
    internal class Program
    {
        //create a program to read three numbers and show them from the largest to the smallest
        static void Main(string[] args)
        {
           
            #region input
            Console.WriteLine("Type the value A: ");
            int valueA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the value B: ");
            int valueB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the value C: ");
            int valueC = Convert.ToInt32(Console.ReadLine());

            #endregion

            #region processing 

            int[] values = { valueA, valueB, valueC };
            Array.Sort(values);
            Array.Reverse(values);

            Console.WriteLine("Numbers from largest to smallest: " + string.Join(", ", values));

            #endregion

            #region output
            Console.ReadLine();
            #endregion
        }
    }
}
